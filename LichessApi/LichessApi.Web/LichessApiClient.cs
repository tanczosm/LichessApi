using LichessApi.Api;
using LichessApi.Api.Account;
using LichessApi.Api.Analysis;
using LichessApi.Api.ArenaTournaments;
using LichessApi.Api.Board;
using LichessApi.Api.Bot;
using LichessApi.Api.Broadcasts;
using LichessApi.Api.Challenges;
using LichessApi.Api.Games;
using LichessApi.Api.Messaging;
using LichessApi.Api.Puzzles;
using LichessApi.Api.Relations;
using LichessApi.Api.Simuls;
using LichessApi.Api.Studies;
using LichessApi.Api.SwissTournaments;
using LichessApi.Api.Teams;
using LichessApi.Api.Users;
using LichessApi.Models;
using System;
using System.Collections.Generic;

namespace LichessApi
{
    public class LichessApiClient
    {
        // Object cache to store api objects
        private Dictionary<Type, object> Areas = new Dictionary<Type, object>();

        // Static global client configuration options
        public static string EndPointBaseUrl { get; set; } = LichessApiDefaults.EndPointBaseUrl;
        public static int RequestTimeout { get; set; } = LichessApiDefaults.RequestTimeout;

        // Configuration properties
        public string AuthToken { get; set; }
        public string[] AuthorizedScopes { get; set; }

        /// <summary>
        /// Create a Lichess client using a bearer authToken obtained via Oauth authentication
        /// or through creating an API access key
        /// </summary>
        /// <param name="authToken">auth token obtained from OAuth or generated in Lichess user preferences</param>
        /// <param name="scopes">list of authorized scopes for this user</param>
        public LichessApiClient(string authToken, string[] authorizedScopes)
        {
            AuthToken = authToken;
            AuthorizedScopes = authorizedScopes;
        }

        // Apis
        public Account Account { get { return GetArea<Account>(); } }
        public Analysis Analysis { get { return GetArea<Analysis>(); } }
        public ArenaTournaments ArenaTournaments { get { return GetArea<ArenaTournaments>(); } }
        public Board Board { get { return GetArea<Board>(); } }
        public Bot Bot { get { return GetArea<Bot>(); } }
        public Broadcasts Broadcasts { get { return GetArea<Broadcasts>(); } }
        public Challenges Challenges { get { return GetArea<Challenges>(); } }
        public Games Games { get { return GetArea<Games>(); } }
        public Messaging Messaging { get { return GetArea<Messaging>(); } }
        public Puzzles Puzzles { get { return GetArea<Puzzles>(); } }
        public Relations Relations { get { return GetArea<Relations>(); } }
        public Simuls Simuls { get { return GetArea<Simuls>(); } }
        public Studies Studies { get { return GetArea<Studies>(); } }
        public SwissTournaments SwissTournaments { get { return GetArea<SwissTournaments>(); } }
        public Teams Teams { get { return GetArea<Teams>(); } }
        public Users Users { get { return GetArea<Users>(); } }


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
                area.Initialize(this);

                // Add area to cache
                Areas.Add(areaType, area);
            }

            return (T)Convert.ChangeType(Areas[areaType], typeof(T));
        }
    }
}
