using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Api.Challenges.Request;
using LichessApi.Web.Api.Challenges.Response;
using LichessApi.Web.Entities.Enum;
using Shouldly;
using System.Net.Http;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using LichessApi.Web.Api.Account.Response;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Challenges
{
    public class Challenges : ApiBase, IChallenges
    {
        /// <summary>
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<EventStreamResponse> StreamIncomingEvents([EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.StreamIncomingEvents(), HttpMethod.Get, token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<EventStreamResponse>(response, token))
            {
                yield return o;
            }
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
            request.Days.ShouldBeGreaterThanOrEqualTo(1);
            request.Days.ShouldBeLessThanOrEqualTo(15);

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
        public Task<Game> ChallengeAI(ChallengeAIRequest request)  
        {
            return API.Post<Game>(LichessApiConstants.EndPoints.ChallengeAI(), null, request.BuildBodyParams());
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
            seconds.ShouldBeLessThanOrEqualTo(86400);

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.AddTimeToOpponentClock(gameId, seconds.ToString()), null, null);
        }

    }
}
