﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachments
    {
        private const string s_apiPath = "encompass/v1/loans";

        public EncompassRestClient Client { get; }

        public string LoanId { get; }

        internal LoanAttachments(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId) => GetAttachmentAsync(attachmentId, CancellationToken.None);

        public Task<LoanAttachment> GetAttachmentAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, cancellationToken, async response =>
            {
                var attachment = await response.Content.ReadAsAsync<LoanAttachment>().ConfigureAwait(false);
                attachment.Dirty = false;
                return attachment;
            });
        }

        public Task<string> GetAttachmentRawAsync(string attachmentId) => GetAttachmentRawAsync(attachmentId, CancellationToken.None);

        public Task<string> GetAttachmentRawAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            return GetAttachmentInternalAsync(attachmentId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetAttachmentInternalAsync<T>(string attachmentId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{LoanId}/attachments/{attachmentId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanAttachment>> GetAttachmentsAsync() => GetAttachmentsAsync(CancellationToken.None);

        public Task<List<LoanAttachment>> GetAttachmentsAsync(CancellationToken cancellationToken) => GetAttachmentsInternalAsync(cancellationToken, async response =>
        {
            var attachments = await response.Content.ReadAsAsync<List<LoanAttachment>>().ConfigureAwait(false);
            foreach (var attachment in attachments)
            {
                attachment.Dirty = false;
            }
            return attachments;
        });

        public Task<string> GetAttachmentsRawAsync() => GetAttachmentsRawAsync(CancellationToken.None);

        public Task<string> GetAttachmentsRawAsync(CancellationToken cancellationToken) => GetAttachmentsInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetAttachmentsInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{LoanId}/attachments", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> GetAttachmentUrlAsync(string attachmentId) => GetAttachmentUrlAsync(attachmentId, CancellationToken.None);

        //TODO: Add support for view query parameter, does this even make sense?
        public async Task<string> GetAttachmentUrlAsync(string attachmentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/{LoanId}/attachments/{attachmentId}/url", null, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetAttachmentUrlAsync), response).ConfigureAwait(false);
                }

                var attachmentUrl = await response.Content.ReadAsAsync<AttachmentUrl>().ConfigureAwait(false);
                return attachmentUrl.MediaUrl;
            }
        }

        private sealed class AttachmentUrl
        {
            public string MediaUrl { get; set; }
        }

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate) => UpdateAttachmentAsync(attachment, populate, CancellationToken.None);

        public Task UpdateAttachmentAsync(LoanAttachment attachment, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachment.AttachmentId, JsonStreamContent.Create(attachment), populate ? new QueryParameters(new QueryParameter("view", "entity")) : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(attachment).ConfigureAwait(false);
                }
                attachment.Dirty = false;
            });
        }

        public Task UpdateAttachmentRawAsync(string attachmentId, string attachment) => UpdateAttachmentRawAsync(attachmentId, attachment, CancellationToken.None);

        public Task UpdateAttachmentRawAsync(string attachmentId, string attachment, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));
            Preconditions.NotNullOrEmpty(attachment, nameof(attachment));

            return UpdateAttachmentInternalAsync(attachmentId, new JsonStringContent(attachment), null, cancellationToken);
        }

        private async Task UpdateAttachmentInternalAsync(string attachmentId, HttpContent content, QueryParameters queryParameters, CancellationToken cancellationToken, Func<HttpResponseMessage, Task> func = null)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{LoanId}/attachments/{attachmentId}{queryParameters}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateAttachmentAsync), response).ConfigureAwait(false);
                }

                if (func != null)
                {
                    await func(response).ConfigureAwait(false);
                }
            }
        }
    }
}