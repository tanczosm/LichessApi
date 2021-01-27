using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LichessApi.Web.Util
{
    /// <summary>
    /// Consomes Ndjson streams
    /// https://www.tpeczek.com/2020/10/consuming-json-objects-stream-ndjson.html
    /// </summary>
    internal static class HttpContentNdjsonExtensions
    {
        private static readonly JsonSerializerOptions _serializerOptions
            = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

        public static async IAsyncEnumerable<TValue> ReadFromNdjsonAsync<TValue>(this HttpContent content, [EnumeratorCancellation] CancellationToken token = default)
        {
            if (content is null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            string? mediaType = content.Headers.ContentType?.MediaType;

            if (mediaType is null || !mediaType.Equals("application/x-ndjson", StringComparison.OrdinalIgnoreCase))
            {
                throw new NotSupportedException();
            }

            Stream contentStream = await content.ReadAsStreamAsync().ConfigureAwait(false);

            using (contentStream)
            {
                using (StreamReader contentStreamReader = new StreamReader(contentStream))
                {
                    while (!contentStreamReader.EndOfStream && !token.IsCancellationRequested)
                    {
                        yield return JsonSerializer.Deserialize<TValue>(await contentStreamReader.ReadLineAsync()
                            .ConfigureAwait(false), _serializerOptions);
                    }
                }
            }
        }
    }
}
