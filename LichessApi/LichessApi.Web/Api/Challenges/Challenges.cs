using LichessApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Api.Challenges
{
    public class Challenges : ApiBase
    {
        /*
        public static Uri CreateChallenge(string username) => EUri($"/api/challenge/{username}");
        public static Uri AcceptChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/accept");
        public static Uri DeclineChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/decline");
        public static Uri CancelChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/cancel");
        public static Uri ChallengeAI() => EUri($"/api/challenge/ai");
        public static Uri OpenEndedChallenge() => EUri($"/api/challenge/open");
        public static Uri StartClocks(string gameId) => EUri($"/api/challenge/{gameId}/start-clocks");
        public static Uri AddTimeToOpponentClock(string gameId, string seconds) => EUri($"/api/round/{gameId}/add-time/{seconds}");
        public static Uri CreateAdminChallenge(string orig, string dest) => EUri($"/api/challenge/admin/{orig}/{dest}");
        */

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> StreamIncomingEvents()
        {
            // See https://www.tpeczek.com/2020/10/consuming-json-objects-stream-ndjson.html
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a challenge
        /// Challenge someone to play.The targeted player can choose to accept or decline.
        ///
        /// If the challenge is accepted, you will be notified on the event stream that a new game has started.The game 
        /// ID will be the same as the challenge ID. If you also have an OAuth token with challenge:write scope for the 
        /// receiving user, you can make them accept the challenge immediately by setting the acceptByToken field.
        /// <see href="https://lichess.org/api#operation/challengeCreate"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> CreateChallenge(string opponent, object request)  // TODO: Create request object
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> AcceptChallenge(string challengeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> DeclineChallenge(string challengeId, object request)  // TODO: Create request object
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> CancelChallenge(string challengeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> ChallengeAI(object request)  // TODO: Create request object
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> CreateOpenEndedChallenge()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> CreateAdminChallenge()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> StartClocks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<bool> AddTimeToOpponentClock()
        {
            throw new NotImplementedException();
        }

    }
}
