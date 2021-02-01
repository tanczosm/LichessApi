using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LichessApi.Web.Http;
using System;
using System.Runtime.Serialization;

namespace LichessApi.Web
{
    [Serializable]
    public class ApiException : Exception
    {
        public IResponse? Response { get; set; }

        public ApiException(IResponse response) : base(ParseAPIErrorMessage(response))
        {
            Ensure.ArgumentNotNull(response, nameof(response));

            Response = response;
        }

        public ApiException()
        {
        }

        public ApiException(string message) : base(message)
        {
        }

        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Response = info.GetValue("ApiException.Response", typeof(IResponse)) as IResponse;
        }

        private static string? ParseAPIErrorMessage(IResponse response)
        {
            var body = response.Body as string;
            if (string.IsNullOrEmpty(body))
            {
                return null;
            }
            try
            {
                JObject bodyObject = JObject.Parse(body!);


                var error = bodyObject.Value<JToken>("error");
                if (error.Type == JTokenType.String)
                {
                    return error.ToString();
                }
                else if (error.Type == JTokenType.Object)
                {
                    return error.Value<string>("message");
                }
            }
            catch (JsonReaderException)
            {
                return null;
            }
            return null;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ApiException.Response", Response);
        }
    }
}
