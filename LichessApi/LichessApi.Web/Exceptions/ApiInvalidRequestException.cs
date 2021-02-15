using System.Runtime.Serialization;
using System;
using LichessApi.Web.Http;

namespace LichessApi.Web
{
    [Serializable]
    public class ApiInvalidRequestException : ApiException
    {
        public ApiInvalidRequestException(IResponse response) : base(response) { }

        public ApiInvalidRequestException() { }

        public ApiInvalidRequestException(string message) : base(message) { }

        public ApiInvalidRequestException(string message, Exception innerException) : base(message, innerException) { }

        protected ApiInvalidRequestException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}