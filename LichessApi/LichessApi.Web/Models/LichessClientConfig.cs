using System.Net.Http;
using System;
using LichessApi.Web.Http;

namespace LichessApi.Web
{
#nullable enable
    public class LichessApiClientConfig
    {
        public Uri BaseAddress { get; private set; }
        public IAuthenticator? Authenticator { get; private set; }
        public IJSONSerializer JSONSerializer { get; private set; }
        public IHTTPClient HTTPClient { get; private set; }
        public IHTTPLogger? HTTPLogger { get; private set; }
        public IApiConnector? ApiConnector { get; private set; }

        /// <summary>
        ///   This config spefies the internal parts of the LichessClient.
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <param name="authenticator"></param>
        /// <param name="jsonSerializer"></param>
        /// <param name="httpClient"></param>
        /// <param name="httpLogger"></param>
        /// <param name="apiConnector"></param>
        public LichessApiClientConfig(
          Uri baseAddress,
          IAuthenticator? authenticator,
          IJSONSerializer jsonSerializer,
          IHTTPClient httpClient,
          IHTTPLogger? httpLogger,
          IApiConnector? apiConnector = null
        )
        {
            BaseAddress = baseAddress;
            Authenticator = authenticator;
            JSONSerializer = jsonSerializer;
            HTTPClient = httpClient;
            HTTPLogger = httpLogger;
            ApiConnector = apiConnector;
        }

        public LichessApiClientConfig WithToken(string token, string tokenType = "Bearer")
        {
            Ensure.ArgumentNotNull(token, nameof(token));

            return new LichessApiClientConfig(
              BaseAddress,
              new TokenAuthenticator(token, tokenType),
              JSONSerializer,
              HTTPClient,
              HTTPLogger
            );
        }

        public LichessApiClientConfig WithAuthenticator(IAuthenticator authenticator)
        {
            Ensure.ArgumentNotNull(authenticator, nameof(authenticator));

            return new LichessApiClientConfig(
              BaseAddress,
              authenticator,
              JSONSerializer,
              HTTPClient,
              HTTPLogger
            );
        }

        public LichessApiClientConfig WithHTTPLogger(IHTTPLogger httpLogger)
        {
            return new LichessApiClientConfig(
              BaseAddress,
              Authenticator,
              JSONSerializer,
              HTTPClient,
              httpLogger
            );
        }

        public LichessApiClientConfig WithHTTPClient(IHTTPClient httpClient)
        {
            Ensure.ArgumentNotNull(httpClient, nameof(httpClient));

            return new LichessApiClientConfig(
              BaseAddress,
              Authenticator,
              JSONSerializer,
              httpClient,
              HTTPLogger
            );
        }

        public LichessApiClientConfig WithJSONSerializer(IJSONSerializer jsonSerializer)
        {
            Ensure.ArgumentNotNull(jsonSerializer, nameof(jsonSerializer));

            return new LichessApiClientConfig(
              BaseAddress,
              Authenticator,
              jsonSerializer,
              HTTPClient,
              HTTPLogger
            );
        }


        public LichessApiClientConfig WithAPIConnector(IApiConnector apiConnector)
        {
            Ensure.ArgumentNotNull(apiConnector, nameof(apiConnector));

            return new LichessApiClientConfig(
              BaseAddress,
              Authenticator,
              JSONSerializer,
              HTTPClient,
              HTTPLogger,
              apiConnector
            );
        }

        public IApiConnector BuildAPIConnector()
        {
            return ApiConnector ?? new ApiConnector(
              BaseAddress,
              Authenticator,
              JSONSerializer,
              HTTPClient,
              HTTPLogger
            );
        }

        public static LichessApiClientConfig CreateDefault(string token, string tokenType = "Bearer")
        {
            return CreateDefault().WithAuthenticator(new TokenAuthenticator(token, tokenType));
        }

        public static LichessApiClientConfig CreateDefault()
        {
            return new LichessApiClientConfig(
              new Uri(LichessApiDefaults.EndPointBaseUrl),
              null,
              new NewtonsoftJSONSerializer(),
              new NetHttpClient(),
              null,
              null
            );
        }
    }
#nullable disable
}
