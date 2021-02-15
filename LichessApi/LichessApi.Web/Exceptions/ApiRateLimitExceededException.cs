using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Http;

namespace LichessApi.Web.Exceptions
{
    [Serializable]
    public class ApiRateLimitExceededException : ApiException
    {
        public ApiRateLimitExceededException(IResponse response) : base(response) { }

        public ApiRateLimitExceededException() { }

        public ApiRateLimitExceededException(string message) : base(message) { }

        public ApiRateLimitExceededException(string message, Exception innerException) : base(message, innerException) { }

        protected ApiRateLimitExceededException(SerializationInfo info, StreamingContext context) { }
    }
}
