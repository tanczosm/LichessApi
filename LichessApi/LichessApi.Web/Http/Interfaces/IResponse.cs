using System.Collections.Generic;
using System.Net;
using System.Threading;

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
