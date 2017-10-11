﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.LoanBatch;
using EncompassRest.LoanPipeline;
using EncompassRest.Token;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class EncompassRestClient : IDisposable
    {
        public static Task<EncompassRestClient> CreateFromUserCredentialsAsync(string clientId, string clientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling = TokenExpirationHandling.Default) => CreateFromUserCredentialsAsync(clientId, clientSecret, instanceId, userId, password, tokenExpirationHandling, CancellationToken.None);

        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(string clientId, string clientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(clientId, nameof(clientId));
            Preconditions.NotNullOrEmpty(clientSecret, nameof(clientSecret));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var client = tokenExpirationHandling == TokenExpirationHandling.RetrieveNewToken ? new EncompassRestClient(clientId, clientSecret, instanceId, userId, password, tokenExpirationHandling) : new EncompassRestClient(clientId, clientSecret);
            await client.AccessToken.SetTokenWithUserCredentialsAsync(instanceId, userId, password, cancellationToken).ConfigureAwait(false);
            return client;
        }

        public static Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string clientId, string clientSecret, string redirectUri, string authorizationCode) => CreateFromAuthorizationCodeAsync(clientId, clientSecret, redirectUri, authorizationCode, CancellationToken.None);

        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string clientId, string clientSecret, string redirectUri, string authorizationCode, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(clientId, nameof(clientId));
            Preconditions.NotNullOrEmpty(clientSecret, nameof(clientSecret));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            var client = new EncompassRestClient(clientId, clientSecret);
            await client.AccessToken.SetTokenWithAuthorizationCodeAsync(redirectUri, authorizationCode, cancellationToken).ConfigureAwait(false);
            return client;
        }

        public static EncompassRestClient CreateFromAccessToken(string clientId, string clientSecret, string accessToken, string tokenType = "Bearer")
        {
            Preconditions.NotNullOrEmpty(clientId, nameof(clientId));
            Preconditions.NotNullOrEmpty(clientSecret, nameof(clientSecret));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));
            Preconditions.NotNullOrEmpty(tokenType, nameof(tokenType));

            var client = new EncompassRestClient(clientId, clientSecret);
            client.AccessToken.Token = accessToken;
            client.AccessToken.Type = tokenType;
            return client;
        }
        
        private readonly string _instanceId;
        private readonly string _userId;
        private readonly string _password;

        private HttpClient _httpClient;
        private Loans.Loans _loans;
        private Schema.Schema _schema;
        private Webhook.Webhook _webhook;
        private Pipeline _pipeline;
        private BatchUpdate _batchUpdate;

        #region Properties
        public AccessToken AccessToken { get; }

        public TokenExpirationHandling TokenExpirationHandling { get; }

        public TimeSpan Timeout
        {
            get
            {
                return HttpClient.Timeout;
            }
            set
            {
                HttpClient.Timeout = value;
                AccessToken.TokenClient.Timeout = value;
            }
        }

        public Loans.Loans Loans
        {
            get
            {
                Loans.Loans loans;
                return _loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans.Loans(this)), null) ?? loans;
            }
        }

        public Schema.Schema Schema
        {
            get
            {
                Schema.Schema schema;
                return _schema ?? Interlocked.CompareExchange(ref _schema, (schema = new Schema.Schema(this)), null) ?? schema;
            }
        }

        public Webhook.Webhook Webhook
        {
            get
            {
                Webhook.Webhook webhook;
                return _webhook ?? Interlocked.CompareExchange(ref _webhook, (webhook = new Webhook.Webhook(this)), null) ?? webhook;
            }
        }

        public Pipeline Pipeline
        {
            get
            {
                Pipeline pipeline;
                return _pipeline ?? Interlocked.CompareExchange(ref _pipeline, (pipeline = new Pipeline(this)), null) ?? pipeline;
            }
        }

        public BatchUpdate BatchUpdate
        {
            get
            {
                BatchUpdate batchUpdate;
                return _batchUpdate ?? Interlocked.CompareExchange(ref _batchUpdate, (batchUpdate = new BatchUpdate(this)), null) ?? batchUpdate;
            }
        }

        internal HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    HttpMessageHandler handler = new HttpClientHandler();
                    if (TokenExpirationHandling == TokenExpirationHandling.RetrieveNewToken)
                    {
                        handler = new RetryHandler(handler, async cancellationToken =>
                        {
                            await AccessToken.SetTokenWithUserCredentialsAsync(_instanceId, _userId, _password, cancellationToken).ConfigureAwait(false);
                            return httpClient.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
                        });
                    }
                    httpClient = new HttpClient(handler)
                    {
                        BaseAddress = new Uri("https://api.elliemae.com/")
                    };
                    httpClient.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
                    httpClient = Interlocked.CompareExchange(ref _httpClient, httpClient, null) ?? httpClient;
                }
                return httpClient;
            }
        }
        #endregion

        internal EncompassRestClient(string clientId, string clientSecret)
        {
            AccessToken = new AccessToken(clientId, clientSecret, this);
        }

        private EncompassRestClient(string clientId, string clientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling)
            : this(clientId, clientSecret)
        {
            _instanceId = instanceId;
            _userId = userId;
            _password = password;
            TokenExpirationHandling = tokenExpirationHandling;
        }

        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
        }

        private AuthenticationHeaderValue GetAuthorizationHeader() => new AuthenticationHeaderValue(AccessToken.Type, AccessToken.Token);

        private sealed class RetryHandler : DelegatingHandler
        {
            private readonly Func<CancellationToken, Task<AuthenticationHeaderValue>> _reinitializeAuthorizationHeader;

            public RetryHandler(HttpMessageHandler innerHandler, Func<CancellationToken, Task<AuthenticationHeaderValue>> reinitializeAuthorizationHeader)
                : base(innerHandler)
            {
                _reinitializeAuthorizationHeader = reinitializeAuthorizationHeader;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    request.Headers.Authorization = await _reinitializeAuthorizationHeader(cancellationToken).ConfigureAwait(false);
                    response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                }
                return response;
            }
        }
    }
}