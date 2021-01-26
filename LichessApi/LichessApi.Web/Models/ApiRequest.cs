using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace LichessApi.Models
{
    public class ApiRequest
    {
        private LichessApiClient LiClient { get; init; }
        public List<string> RequiredScopes { get; init; }

        public ApiRequest(LichessApiClient liClient, string endpointUrl, Method method, bool authorize = true, object payload = null, string[] requiredScopes = null)
        {
            LiClient = liClient;

            Client = new RestClient(LichessApiClient.EndPointBaseUrl);
            Request = new RestRequest
            {
                Resource = endpointUrl,
                Timeout = LichessApiClient.RequestTimeout,
                Method = method
            };

            RequiredScopes = requiredScopes == null ? requiredScopes.ToList() : new List<string>();

            if (authorize)
            {
                Request.AddHeader("Authorization", "bearer " + liClient.AuthToken);
            }

            if (payload != null)
            {
                AddPayload(payload);
            }
        }

        public void AddPayload (object payload)
        {
            foreach (PropertyInfo prop in payload.GetType().GetProperties())
            {
                object value = prop.GetValue(payload, null);

                if (value != null)
                {
                    // Check to see if there is a json property attribute name in the request payload class
                    // so we can use that as the proper request field name if available
                    var attribs = prop.GetCustomAttributes<JsonPropertyAttribute>().FirstOrDefault();
                    var propname = attribs != null ? attribs.PropertyName : prop.Name;
                    
                    Request.AddParameter(propname, value);
                }
            }
        }

        public async Task<ApiResponse<T>> Execute<T> () where T : class
        {
            ApiResponse<T> fr = new ApiResponse<T>();

            // Check to see if there are any required claims that are not currently authorized in the client
            var missingScopes = RequiredScopes.Except(LiClient.AuthorizedScopes).ToList();

            if (missingScopes.Count > 0)
            {
                string claims = String.Join(", ", missingScopes);
                fr.ErrorMessage = $"Unable to complete request.  The following OAuth claims are missing for this request: {claims}";
                fr.StatusCode = 400;
                fr.Result = null;
            }
            else
            {
                var response = await ExecuteAPITaskAsync(Client, Request);

                if (response.IsSuccessful)
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<ApiResponse<T>>(response.Content);
                    }
                    catch (Exception e)
                    {
                        // Track error
                    }
                }

                fr.ErrorMessage = response.ErrorMessage;
                fr.ErrorException = response.ErrorException;
                fr.StatusCode = (int)response.StatusCode;
                fr.Result = null;
            }
            

            return fr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<IRestResponse> ExecuteAPITaskAsync(IRestClient client, IRestRequest request)
        {
            var response = await client.ExecuteAsync(request);

            if (response.ResponseStatus == ResponseStatus.Error)
            {
                // Network Unavailable localization key
                response.ErrorMessage = "Network Unavailable";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadGateway)
            {
                // 502 bad gateway. NGINX is running, but the Docker container is unreachable
                response.ErrorMessage = "Bad Gateway";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
            {
                // 503 service unavailable
                response.ErrorMessage = "Network Service Unavailable";
            }
            else if (response.ResponseStatus == ResponseStatus.TimedOut)
            {
                response.ErrorMessage = "Connection Timed Out";
            }
            else
            {
                response.ErrorMessage = response.StatusDescription;
            }

            return response;
        }

        public RestRequest Request { get; }
        public RestClient Client { get;  }
    }
}
