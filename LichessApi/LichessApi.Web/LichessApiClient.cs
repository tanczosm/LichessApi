#region using statements
using LichessApi.Web.Api;
using LichessApi.Web.Api.Account;
using LichessApi.Web.Api.Analysis;
using LichessApi.Web.Api.ArenaTournaments;
using LichessApi.Web.Api.Board;
using LichessApi.Web.Api.Bot;
using LichessApi.Web.Api.Broadcasts;
using LichessApi.Web.Api.Challenges;
using LichessApi.Web.Api.Games;
using LichessApi.Web.Api.Messaging;
using LichessApi.Web.Api.Puzzles;
using LichessApi.Web.Api.Relations;
using LichessApi.Web.Api.Simuls;
using LichessApi.Web.Api.Studies;
using LichessApi.Web.Api.SwissTournaments;
using LichessApi.Web.Api.Teams;
using LichessApi.Web.Api.Users;
using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using LichessApi.Web;
using LichessApi.Web.Api.BulkPairings;
using LichessApi.Web.Http;
#endregion 

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi
{
    public class LichessApiClient : ILichessApiClient
    {
        // Object cache to store api objects
        private Dictionary<Type, object> Areas = new Dictionary<Type, object>();

        // Configuration properties
        public LichessApiClientConfig Configuration { get; init; }
        protected IApiConnector API { get; init; }

        public LichessApiClient(string token, string tokenType = "Bearer") :
            this(LichessApiClientConfig.CreateDefault(token, tokenType))
        { }

        /// <summary>
        /// Create a Lichess client using a bearer authToken obtained via Oauth authentication
        /// or through creating an API access key
        /// </summary>
        /// <param name="authToken">auth token obtained from OAuth or generated in Lichess user preferences</param>
        public LichessApiClient(LichessApiClientConfig config)
        {
            Ensure.ArgumentNotNull(config, nameof(config));
            if (config.Authenticator == null)
            {
#pragma warning disable CA2208
                throw new ArgumentNullException("Authenticator in config is null. Please supply it via `WithAuthenticator` or `WithToken`");
#pragma warning restore CA2208
            }

            Configuration = config;

            API = config.BuildAPIConnector();

            API.ResponseReceived += (sender, response) =>
            {
                LastResponse = response;
            };

            Connector = API;
        }

        // Apis
        public IAccount Account { get { return GetArea<Account>(); } }
        public IAnalysis Analysis { get { return GetArea<Analysis>(); } }
        public IArenaTournaments ArenaTournaments { get { return GetArea<ArenaTournaments>(); } }
        public IBoard Board { get { return GetArea<Board>(); } }
        public IBot Bot { get { return GetArea<Bot>(); } }
        public IBroadcasts Broadcasts { get { return GetArea<Broadcasts>(); } }
        public IBulkPairings BulkPairings { get { return GetArea<BulkPairings>(); } }
        public IChallenges Challenges { get { return GetArea<Challenges>(); } }
        public IGames Games { get { return GetArea<Games>(); } }
        public IMessaging Messaging { get { return GetArea<Messaging>(); } }
        public IPuzzles Puzzles { get { return GetArea<Puzzles>(); } }
        public IRelations Relations { get { return GetArea<Relations>(); } }
        public ISimuls Simuls { get { return GetArea<Simuls>(); } }
        public IStudies Studies { get { return GetArea<Studies>(); } }
        public ISwissTournaments SwissTournaments { get { return GetArea<SwissTournaments>(); } }
        public ITeams Teams { get { return GetArea<Teams>(); } }
        public IUsers Users { get { return GetArea<Users>(); } }
      
        public IResponse? LastResponse { get; private set; }
        public IApiConnector Connector { get; private set; }

        /// <summary>
        /// Allows for lazy initialization of api clients
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T GetArea<T> () where T : ICanInitialize, new()
        {
            Type areaType = typeof(T);
            if (!Areas.ContainsKey(areaType))
            {
                // Create new area
                T area = new T();

                // Inject the lichessNetClient reference
                area.Initialize(API);

                // Add area to cache
                Areas.Add(areaType, area);
            }

            return (T)Convert.ChangeType(Areas[areaType], typeof(T));
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
