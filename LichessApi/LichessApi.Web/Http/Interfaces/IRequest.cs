using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
    public interface IRequest
    {
        Uri BaseAddress { get; }

        Uri Endpoint { get; }

        IDictionary<string, string> Headers { get; }

        IDictionary<string, string> Parameters { get; }

        HttpMethod Method { get; }

        object? Body { get; set; }

        CancellationToken CancellationToken { get; set; }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
