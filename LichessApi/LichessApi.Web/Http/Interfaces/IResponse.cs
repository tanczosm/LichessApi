using System.Collections.Generic;
using System.Net;
using System.Threading;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
    public interface IResponse
    {
        object? Body { get; }

        IReadOnlyDictionary<string, string> Headers { get; }

        HttpStatusCode StatusCode { get; }

        string? ContentType { get; }

    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
