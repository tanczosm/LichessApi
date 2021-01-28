using System.Runtime.Serialization;
using System;
using LichessApi.Web.Http;

namespace LichessApi.Web
{
    [Serializable]
    public class ApiInvalidRequest : ApiException
    {
        public ApiInvalidRequest(IResponse response) : base(response) { }

        public ApiInvalidRequest() { }

        public ApiInvalidRequest(string message) : base(message) { }

        public ApiInvalidRequest(string message, Exception innerException) : base(message, innerException) { }

        protected ApiInvalidRequest(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}