﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public abstract class ApiObject
    {
        private static readonly HttpMethod s_patchMethod = new HttpMethod("PATCH");

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadAsStringFunc = response => response.Content.ReadAsStringAsync();

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadLocationFunc = response => Task.FromResult(GetLocation(response));

        internal static readonly Func<HttpResponseMessage, Task<string>> ReadAsStringElseLocationFunc = response => response.Content.Headers.ContentLength > 0 ? response.Content.ReadAsStringAsync() : Task.FromResult(GetLocation(response));

        internal static readonly Func<HttpResponseMessage, Task<bool>> IsSuccessStatusCodeFunc = response => Task.FromResult(response.IsSuccessStatusCode);

        internal const string ViewEntityQueryString = "?view=entity";

        internal static string GetLocation(HttpResponseMessage response) => Path.GetFileName(response.Headers.Location.OriginalString);

        private readonly string _baseApiPath;

        public EncompassRestClient Client { get; }

        internal ApiObject(EncompassRestClient client, string baseApiPath)
        {
            Client = client;
            _baseApiPath = baseApiPath;
        }

        internal Task<T> GetAsync<T>(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, FuncCache<T>.ReadAsFunc);

        internal Task<T> GetDirtyAsync<T>(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) where T : class, IDirty => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, DirtyFuncCache<T>.ReadAsDirtyFunc);

        internal Task<List<T>> GetDirtyListAsync<T>(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) where T : class, IDirty => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, DirtyFuncCache<T>.ReadAsDirtyListFunc);

        internal Task<string> GetRawAsync(string requestUri, string queryString, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Get, requestUri, queryString, null, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task<T> PostAsync<T>(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, FuncCache<T>.ReadAsFunc);

        internal Task<string> PostRawAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task<string> PostPopulateDirtyAsync<T>(string requestUri, T value, string methodName, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => PostPopulateDirtyAsync(requestUri, populate ? ViewEntityQueryString : null, value, methodName, populate, cancellationToken);

        internal Task<string> PostPopulateDirtyAsync<T>(string requestUri, string queryString, T value, string methodName, bool populate, CancellationToken cancellationToken) where T : class, IDirty, IIdentifiable => SendAsync(HttpMethod.Post, requestUri, queryString, JsonStreamContent.Create(value), methodName, null, cancellationToken, async response =>
        {
            var id = GetLocation(response);
            value.Id = id;
            if (populate)
            {
                await response.Content.PopulateAsync(value).ConfigureAwait(false);
            }
            value.Dirty = false;
            return id;
        });

        internal Task<T> PostAsync<T>(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func, bool throwOnNonSuccessStatusCode = true) => SendAsync(HttpMethod.Post, requestUri, queryString, content, methodName, resourceId, cancellationToken, func, throwOnNonSuccessStatusCode);

        internal Task PatchAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync<string>(s_patchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, null);

        internal Task<string> PatchRawAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(s_patchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task PatchPopulateDirtyAsync(string requestUri, HttpContent content, string methodName, string resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(s_patchMethod, requestUri, populate ? ViewEntityQueryString : null, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task PatchPopulateDirtyAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(s_patchMethod, requestUri, queryString, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task<T> PatchAsync<T>(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) => SendAsync(s_patchMethod, requestUri, queryString, content, methodName, resourceId, cancellationToken, func);

        internal Task PutAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync<string>(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, null);

        internal Task<string> PutRawAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken) => SendAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, ReadAsStringFunc);

        internal Task PutPopulateDirtyAsync(string requestUri, HttpContent content, string methodName, string resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Put, requestUri, populate ? ViewEntityQueryString : null, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task PutPopulateDirtyAsync(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => PopulateDirtyInternalAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, target, populate, cancellationToken);

        internal Task<T> PutAsync<T>(string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func) => SendAsync(HttpMethod.Put, requestUri, queryString, content, methodName, resourceId, cancellationToken, func);

        internal Task<bool> DeleteAsync(string requestUri, string queryString, CancellationToken cancellationToken) => SendAsync(HttpMethod.Delete, requestUri, queryString, null, null, null, cancellationToken, IsSuccessStatusCodeFunc, false);

        private Task PopulateDirtyInternalAsync(HttpMethod method, string requestUri, string queryString, HttpContent content, string methodName, string resourceId, IDirty target, bool populate, CancellationToken cancellationToken) => SendAsync(method, requestUri, queryString, content, methodName, resourceId, cancellationToken, async response =>
        {
            if (populate)
            {
                await response.Content.PopulateAsync(target).ConfigureAwait(false);
            }
            target.Dirty = false;
            return string.Empty;
        });

        private async Task<T> SendAsync<T>(HttpMethod method, string requestUri, string queryString, HttpContent content, string methodName, string resourceId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func, bool throwOnNonSuccessStatusCode = true)
        {
            using (var request = new HttpRequestMessage(method, $"{_baseApiPath}{requestUri?.PrecedeWith("/")}{queryString?.PrecedeWith("?")}") { Content = content })
            {
                using (var response = await GetHttpClient().SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false))
                {
                    if (throwOnNonSuccessStatusCode && !response.IsSuccessStatusCode)
                    {
                        throw await EncompassRestException.CreateAsync(CreateErrorMessage(methodName, resourceId), response).ConfigureAwait(false);
                    }

                    if (func != null)
                    {
                        return await func(response).ConfigureAwait(false);
                    }
                    return default;
                }
            }
        }

        internal virtual string CreateErrorMessage(string methodName, string resourceId = null) => $"{methodName}{resourceId?.PrecedeWith(": ")}";

        internal virtual HttpClient GetHttpClient() => Client.HttpClient;

        internal static class FuncCache<T>
        {
            public static readonly Func<HttpResponseMessage, Task<T>> ReadAsFunc = response => response.Content.ReadAsAsync<T>();
        }

        internal static class DirtyFuncCache<T>
            where T : class, IDirty
        {
            public static readonly Func<HttpResponseMessage, Task<T>> ReadAsDirtyFunc = async response =>
            {
                var value = await response.Content.ReadAsAsync<T>().ConfigureAwait(false);
                value.Dirty = false;
                return value;
            };

            public static readonly Func<HttpResponseMessage, Task<List<T>>> ReadAsDirtyListFunc = async response =>
            {
                var list = await response.Content.ReadAsAsync<List<T>>().ConfigureAwait(false);
                foreach (var item in list)
                {
                    item.Dirty = false;
                }
                return list;
            };
        }
    }
}