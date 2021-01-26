using LichessNet.Api;
using LichessNet.Api.Account;
using LichessNet.Api.Analysis;
using LichessNet.Api.ArenaTournaments;
using LichessNet.Api.Board;
using LichessNet.Api.Bot;
using LichessNet.Api.Broadcasts;
using LichessNet.Api.Challenges;
using LichessNet.Api.Games;
using LichessNet.Api.Messaging;
using LichessNet.Api.Puzzles;
using LichessNet.Api.Relations;
using LichessNet.Api.Simuls;
using LichessNet.Api.Studies;
using LichessNet.Api.SwissTournaments;
using LichessNet.Api.Teams;
using LichessNet.Api.Users;
using LichessNet.Models;
using System;
using System.Collections.Generic;

namespace LichessNet
{
    public class LichessNetClient
    {
        // Object cache to store api objects
        private Dictionary<Type, object> Areas = new Dictionary<Type, object>();

        // Static global client configuration options
        public static string EndPointBaseUrl { get; set; } = LichessNetDefaults.EndPointBaseUrl;
        public static int RequestTimeout { get; set; } = LichessNetDefaults.RequestTimeout;

        // Configuration properties
        public string AuthToken { get; set; }
        public string[] Claims { get; set; }

        /// <summary>
        /// Create a Lichess client using a bearer authToken obtained via Oauth authentication
        /// or through creating an API access key
        /// </summary>
        /// <param name="authToken">auth token obtained from OAuth or generated in Lichess user preferences</param>
        /// <param name="claims">list of claims that have been authorized for this user</param>
        public LichessNetClient(string authToken, string[] claims)
        {
            AuthToken = authToken;
            Claims = claims;
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
