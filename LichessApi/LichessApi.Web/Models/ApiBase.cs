using LichessApi.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api;
using LichessApi.Web.Api.Challenges.Response;
using LichessApi.Web.Http;
using Shouldly;

namespace LichessApi.Web.Models
{
    public class ApiBase : ICanInitialize
    {
        protected IApiConnector API { get; private set; }

        public void Initialize(IApiConnector api)
        {
            this.API = api;
        }

        public async IAsyncEnumerable<T> StreamNdJson<T>(IResponse response, [EnumeratorCancellation] CancellationToken token = default) 
        {
            var taskCompletionSource = new TaskCompletionSource<decimal>();

            // Register cancellation delegate with token
            token.Register(() =>
            {
                // We received a cancellation message, cancel the TaskCompletionSource.Task
                taskCompletionSource.TrySetCanceled();
            });

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                response.Body.ShouldNotBeNull();

                await using (response.Body as Stream)
                {
                    using (StreamReader contentStreamReader = new StreamReader(response.Body! as Stream))
                    {
                        while (!token.IsCancellationRequested)
                        {
                            // Generate new mock headers
                            Http.Response apiResponse = new Http.Response(response.Headers.Select(dict => dict)
                                .ToDictionary(pair => pair.Key, pair => pair.Value));

                            string body = null;

                            try
                            {
                                Task<string> reader = contentStreamReader.ReadLineAsync();

                                // Does the reader task complete first or is the token cancelled?
                                await Task.WhenAny(reader, taskCompletionSource.Task);

                                if (reader.IsCompleted)
                                {
                                    body = reader.Result;
                                }

                            }
                            catch (Exception e)
                            {
                                // Catch IO errors
                            }

                            if (body is null)
                                yield break;

                            if (body.Length == 0)
                                continue;

                            apiResponse.ContentType = "application/json";
                            apiResponse.Body = body;

                            yield return API.JSONSerializer
                                .DeserializeResponse<T>(apiResponse).Body;
                        }
                    }
                }
            }

            yield break;
        }
    }
}
