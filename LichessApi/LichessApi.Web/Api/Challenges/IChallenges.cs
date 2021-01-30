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
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Challenges
{
    public interface IChallenges
    {
        void Initialize(IApiConnector api);
        IAsyncEnumerable<EventStreamResponse> StreamIncomingEvents(CancellationToken token = default);
        Task<Challenge> CreateChallenge(string opponentUsername, ChallengeRequest request);
        Task<GameResponse> CreateGame(string opponentUsername, string opponentToken, CreateGameRequest request);
        Task<OkResponse> AcceptChallenge(string challengeId);
        Task<OkResponse> DeclineChallenge(string challengeId, ChallengeDeclineReason reason);
        Task<OkResponse> CancelChallenge(string challengeId);
        Task<Game> ChallengeAI(ChallengeAIRequest request);
        Task<ChallengeResponse> CreateOpenEndedChallenge(CreateOpenEndedChallengeRequest request);
        Task<ChallengeResponse> CreateAdminChallenge(string username1, string username2, ChallengeRequest request);
        Task<OkResponse> StartClocks(string gameId, string token1, string token2);
        Task<OkResponse> AddTimeToOpponentClock(string gameId, int seconds);

    }
}
