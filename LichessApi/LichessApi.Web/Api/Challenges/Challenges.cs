using LichessApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Api.Challenges.Request;
using LichessApi.Web;
using LichessApi.Web.Api.Challenges.Response;
using LichessApi.Api.Account.Response;
using LichessApi.Web.Api.Challenges.Request;
using LichessApi.Web.Entities.Enum;
using Shouldly;

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
        public Task<Challenge> CreateChallenge(string opponentUsername, CreateChallengeRequest request)
        {
            request.Days.ShouldBeGreaterThan(0);
            request.Days.ShouldBeLessThan(16);

            return API.Post<Challenge>(LichessApiConstants.EndPoints.CreateChallenge(opponentUsername), null, request.BuildBodyParams());
        }

        // TODO: Verify if this works as the documentation is a little sketchy
        public Task<GameResponse> CreateGame(string opponentUsername, string opponentToken, CreateGameRequest request)
        {
            request.acceptByToken = opponentToken;
            
            return API.Post<GameResponse>(LichessApiConstants.EndPoints.CreateChallenge(opponentUsername), null, request.BuildBodyParams());
        }


        /// <summary>
        /// Accept an incoming challenge.
        /// You should receive a gameStart event on the incoming events stream.
        /// Required Scopes:
        ///  LichessApiConstants.Scopes.ChallengeWrite;
        ///  LichessApiConstants.Scopes.BotPlay;
        ///  LichessApiConstants.Scopes.BoardPlay
        /// <see href="https://lichess.org/api#operation/challengeAccept"/></see>
        /// </summary>
        /// <returns>OkResponse</returns>
        public Task<OkResponse> AcceptChallenge(string challengeId)
        {
            return API.Post<OkResponse>(LichessApiConstants.EndPoints.AcceptChallenge(challengeId), null);
        }

        /// <summary>
        /// Decline an incoming challenge.
        /// Required Scopes:
        ///  LichessApiConstants.Scopes.ChallengeWrite;
        ///  LichessApiConstants.Scopes.BotPlay;
        ///  LichessApiConstants.Scopes.BoardPlay
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> DeclineChallenge(string challengeId, ChallengeDeclineReason reason)
        {
            var request = new DeclineChallengeRequest
            {
                Reason = reason
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.DeclineChallenge(challengeId), null, request.BuildBodyParams());
        }

        /// <summary>
        /// Cancel an incoming challenge.
        /// Required Scopes:
        ///  LichessApiConstants.Scopes.ChallengeWrite;
        ///  LichessApiConstants.Scopes.BotPlay;
        ///  LichessApiConstants.Scopes.BoardPlay
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> CancelChallenge(string challengeId)
        {
            return API.Post<OkResponse>(LichessApiConstants.EndPoints.CancelChallenge(challengeId), null);
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ChallengeAIResponse> ChallengeAI(ChallengeAIRequest request)  
        {
            return API.Post<ChallengeAIResponse>(LichessApiConstants.EndPoints.ChallengeAI(), null, request.BuildBodyParams());
        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ChallengeResponse> CreateOpenEndedChallenge(CreateOpenEndedChallengeRequest request)
        {

            return API.Post<ChallengeResponse>(LichessApiConstants.EndPoints.ChallengeAI(), null, request.BuildBodyParams());
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
