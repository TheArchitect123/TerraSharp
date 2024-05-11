﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Terra.Microsoft.Rest.Constants;

namespace Terra.Microsoft.Rest.Util
{
    public class TerraHttpClientService
    {
        private HttpClient httpClient;

        public void PrepareHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;

            // Add all default Headers
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Mimes.JSON));
            this.httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        private async Task<HttpResponseMessage> RunHttpOperation(
            Func<CancellationTokenSource, Task<HttpResponseMessage>> runOperation,
            CancellationTokenSource upperToken = null)
        {
            if (upperToken != null)
            {
                if (!upperToken.IsCancellationRequested)
                {
                    upperToken.CancelAfter(HttpBehaviourConstants.DefaultHttpTimeoutSeconds * 1000);
                    using (upperToken)
                    {
                        return await runOperation(upperToken);
                    }
                }
            }
            else
            {
                using (var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(HttpBehaviourConstants.DefaultHttpTimeoutSeconds)))
                {
                    return await runOperation(tokenSource);
                }
            }

            throw new TaskCanceledException("Cancellation Requested for task");
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.DeleteAsync(requestUri, source.Token), upperToken);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.GetAsync(requestUri,
                HttpCompletionOption.ResponseContentRead, source.Token), upperToken);
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content = null, CancellationTokenSource upperToken = null)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, new Uri(requestUri)))
            {
                if (content != null)
                {
                    request.Content = content;
                }

                return await this.RunHttpOperation((source) => this.httpClient.SendAsync(request,
                    HttpCompletionOption.ResponseContentRead, source.Token), upperToken);
            }
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationTokenSource upperToken = null)
        {
            return await this.RunHttpOperation((source) => this.httpClient.PutAsync(requestUri, content, source.Token), upperToken);
        }

        public void ForceDisconnectAllClients()
        {
            this.httpClient.CancelPendingRequests();
        }
    }
}
