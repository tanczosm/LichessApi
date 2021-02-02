using System.Linq;
using System;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
   
    public class SimpleConsoleHTTPLogger : IHTTPLogger
    {
        private const string OnRequestFormat = "\n{0} {1} [{2}] {3}";

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303")]
        public void OnRequest(IRequest request)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            string? parameters = null;
            if (request.Parameters != null)
            {
                parameters = string.Join(",",
                  request.Parameters.Select(kv => kv.Key + "=" + kv.Value)?.ToArray() ?? Array.Empty<string>()
                );
            }

            Console.WriteLine(OnRequestFormat, request.Method, request.Endpoint, parameters, request.Body);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303")]
        public void OnResponse(IResponse response)
        {
            Ensure.ArgumentNotNull(response, nameof(response));
#if NETSTANDARD2_0
      string? body = response.Body?.ToString().Replace("\n", "");
#else
            string? body = response.Body?.ToString()?.Replace("\n", "", StringComparison.InvariantCulture);
#endif

            body = body?.Substring(0, Math.Min(50, body.Length));
            Console.WriteLine("--> {0} {1} {2}\n", response.StatusCode, response.ContentType, body);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
