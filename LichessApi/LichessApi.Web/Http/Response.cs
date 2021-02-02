using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Threading;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
    public class Response : IResponse
    {
        public Response(IDictionary<string, string> headers)
        {
            Ensure.ArgumentNotNull(headers, nameof(headers));

            Headers = new ReadOnlyDictionary<string, string>(headers);
        }

        public object? Body { get; set; }

        public IReadOnlyDictionary<string, string> Headers { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string? ContentType { get; set; }

    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
