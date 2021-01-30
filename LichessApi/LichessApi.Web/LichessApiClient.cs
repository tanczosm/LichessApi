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
using LichessApi.Web.Http;

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
        }

        // Apis
        public IAccount Account { get { return (IAccount)GetArea<Account>(); } }
        public IAnalysis Analysis { get { return (IAnalysis)GetArea<Analysis>(); } }
        public IArenaTournaments ArenaTournaments { get { return (IArenaTournaments)GetArea<ArenaTournaments>(); } }
        public IBoard Board { get { return (IBoard)GetArea<Board>(); } }
        public IBot Bot { get { return (IBot)GetArea<Bot>(); } }
        public IBroadcasts Broadcasts { get { return (IBroadcasts)GetArea<Broadcasts>(); } }
        public IChallenges Challenges { get { return (IChallenges)GetArea<Challenges>(); } }
        public IGames Games { get { return (IGames)GetArea<Games>(); } }
        public IMessaging Messaging { get { return (IMessaging)GetArea<Messaging>(); } }
        public IPuzzles Puzzles { get { return (IPuzzles)GetArea<Puzzles>(); } }
        public IRelations Relations { get { return (IRelations)GetArea<Relations>(); } }
        public ISimuls Simuls { get { return (ISimuls)GetArea<Simuls>(); } }
        public IStudies Studies { get { return (IStudies)GetArea<Studies>(); } }
        public ISwissTournaments SwissTournaments { get { return (ISwissTournaments)GetArea<SwissTournaments>(); } }
        public ITeams Teams { get { return (ITeams)GetArea<Teams>(); } }
        public IUsers Users { get { return (IUsers)GetArea<Users>(); } }
        public IResponse? LastResponse { get; private set; }

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
