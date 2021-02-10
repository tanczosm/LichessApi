using System.Collections.Generic;
using System.Reflection;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using LichessApi.Util.Converters;
using LichessApi.Web.Util.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace LichessApi.Web.Http
{
    public class NewtonsoftJSONSerializer : IJSONSerializer
    {
        private readonly JsonSerializerSettings _serializerSettings;

        public NewtonsoftJSONSerializer()
        {
            var contractResolver = new PrivateFieldDefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            _serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = contractResolver,
                Converters =
                {
                    new StringEnumConverter(),
                    new MillisecondEpochConverter(),
                    new RatingEntryConverter()
                }
            };
        }

        public IApiResponse<T> DeserializeResponse<T>(IResponse response)
        {
            Ensure.ArgumentNotNull(response, nameof(response));

            if (
              (
                response.ContentType?.Equals("application/json", StringComparison.Ordinal) is true ||
                response.ContentType?.Equals("application/vnd.lichess.v3+json", StringComparison.Ordinal) is true ||
                response.ContentType == null
              ))
            {
                var body = JsonConvert.DeserializeObject<T>(response.Body as string ?? "", _serializerSettings);
                return new ApiResponse<T>(response, body!);
            }
            return new ApiResponse<T>(response);
        }

        public void SerializeRequest(IRequest request)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            if (request.Body is string || request.Body is Stream || request.Body is HttpContent || request.Body is null)
            {
                return;
            }

            request.Body = JsonConvert.SerializeObject(request.Body, _serializerSettings);
        }

        private class PrivateFieldDefaultContractResolver : DefaultContractResolver
        {
            protected override List<MemberInfo> GetSerializableMembers(Type objectType)
            {
                // Does not seem to work, still need DefaultMembersSearchFlags |= BindingFlags.NonPublic
                var list = base.GetSerializableMembers(objectType);
                list.AddRange(objectType.GetProperties(BindingFlags.NonPublic));
                return list;
            }
        }
    }
}
