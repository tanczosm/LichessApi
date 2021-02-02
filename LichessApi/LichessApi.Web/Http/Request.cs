using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
    public class Request : IRequest
    {
        public Request(Uri baseAddress, Uri endpoint, HttpMethod method)
        {
            Headers = new Dictionary<string, string>();
            Parameters = new Dictionary<string, string>();
            BaseAddress = baseAddress;
            Endpoint = endpoint;
            Method = method;
        }

        public Request(Uri baseAddress, Uri endpoint, HttpMethod method, IDictionary<string, string> headers)
        {
            Headers = headers;
            Parameters = new Dictionary<string, string>();
            BaseAddress = baseAddress;
            Endpoint = endpoint;
            Method = method;
        }

        public Request(
          Uri baseAddress,
          Uri endpoint,
          HttpMethod method,
          IDictionary<string, string> headers,
          IDictionary<string, string> parameters)
        {
            Headers = headers;
            Parameters = parameters;
            BaseAddress = baseAddress;
            Endpoint = endpoint;
            Method = method;
        }

        public Uri BaseAddress { get; set; }

        public Uri Endpoint { get; set; }

        public IDictionary<string, string> Headers { get; }

        public IDictionary<string, string> Parameters { get; }

        public HttpMethod Method { get; set; }

        public object? Body { get; set; }

        public CancellationToken CancellationToken { get; set; }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
