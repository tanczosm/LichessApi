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
using System.Net.Http;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using LichessApi.Web.Http;

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
        public async IAsyncEnumerable<EventStreamResponse> StreamIncomingEvents([EnumeratorCancellation] CancellationToken token = default)
        {
            // See https://www.tpeczek.com/2020/10/consuming-json-objects-stream-ndjson.html

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.StreamIncomingEvents(), HttpMethod.Get).ConfigureAwait(false);
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {                
                using (response.Body as Stream)
                {
                    using (StreamReader contentStreamReader = new StreamReader(response.Body as Stream))
                    {
                        while (!contentStreamReader.EndOfStream && !token.IsCancellationRequested)
                        {
                            // Generate new mock headers

                            Response apiResponse = new Response (response.Headers.Select(dict => dict).ToDictionary(pair => pair.Key, pair => pair.Value)) { 
                                Body = await contentStreamReader.ReadLineAsync()
                            };
                            apiResponse.ContentType = "application/json";

                            yield return API.JSONSerializer.DeserializeResponse<EventStreamResponse>(apiResponse as IResponse).Body;
                        }
                    }
                }
            }

            yield break;
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
        public Task<Challenge> CreateChallenge(string opponentUsername, ChallengeRequest request)
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
        /// Start a game with Lichess AI.
        /// You will be notified on the event stream that a new game has started.
        /// <see href="https://lichess.org/api#operation/challengeAi"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ChallengeAIResponse> ChallengeAI(ChallengeAIRequest request)  
        {
            return API.Post<ChallengeAIResponse>(LichessApiConstants.EndPoints.ChallengeAI(), null, request.BuildBodyParams());
        }

        /// <summary>
        /// Create a challenge that any 2 players can join.
        /// Share the URL of the challenge.the first 2 players to click it will be paired for a game.
        /// The response body also contains whiteUrl and blackUrl. You can control which color each player gets by giving them 
        /// these URLs, instead of the main challenge URL.
        ///
        /// Open challenges expire after 24h.
        /// To directly pair 2 known players, use the CreateGame() endpoint instead, with the acceptByToken parameter.
        /// <see href="https://lichess.org/api#operation/challengeOpen"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ChallengeResponse> CreateOpenEndedChallenge(CreateOpenEndedChallengeRequest request)
        {

            return API.Post<ChallengeResponse>(LichessApiConstants.EndPoints.OpenEndedChallenge(), null, request.BuildBodyParams());
        }

        /// <summary>
        /// For administrators only. You are not allowed to use this endpoint. Use Create a challenge instead.
        /// Create a challenge between any two players, without OAuth tokens.The challenge will be immediately accepted, and a game created.
        /// <see href="https://lichess.org/api#operation/challengeCreateAdmin"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ChallengeResponse> CreateAdminChallenge(string username1, string username2, ChallengeRequest request)
        {
            return API.Post<ChallengeResponse>(LichessApiConstants.EndPoints.CreateAdminChallenge(username1, username2), null, request.BuildBodyParams());
        }

        /// <summary>
        /// Start the clocks of a game immediately, even if a player has not yet made a move.
        /// Requires the OAuth tokens of both players with challenge:write scope.
        /// If the clocks have already started, the call will have no effect.
        /// <see href="https://lichess.org/api#operation/challengeStartClocks"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> StartClocks(string gameId, string token1, string token2)
        {
            var request = new StartClockRequest
            {
                Token1 = token1,
                Token2 = token2
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.StartClocks(gameId), null, request.BuildBodyParams());

        }

        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> AddTimeToOpponentClock(string gameId, int seconds)
        {
            seconds.ShouldBeLessThan(86401);

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.AddTimeToOpponentClock(gameId, seconds.ToString()), null, null);
        }

    }
}
