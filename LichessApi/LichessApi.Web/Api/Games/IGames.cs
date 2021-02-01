using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Games.Request;
using LichessApi.Web.Api.Games.Response;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Games
{
    public interface IGames
    {
        void Initialize(IApiConnector api);
        Task<Game> ExportOneGame(string gameId, ExportGameRequest request);
        Task<Game> ExportOngoingGameOfUser(string username, ExportGameRequest request);
        Task<UserExtended> ExportGames(string username, ExportGamesRequest request);

        IAsyncEnumerable<Game> ExportGamesByUser(string username, ExportGamesRequest request,
            CancellationToken token = default);

        IAsyncEnumerable<Game> ExportGamesByIds(ExportGamesByIdsRequest request, List<string> gameIds,
            CancellationToken token = default);

        IAsyncEnumerable<Game> StreamCurrentGames(List<string> userIds,
            CancellationToken token = default);

        Task<OngoingGamesResponse> GetOngoingGames(int maxNumberOfGamesToFetch);
        Task<CurrentTVGameResponse> GetCurrentTVGames();

        IAsyncEnumerable<StreamCurrentTVGameResponse> StreamCurrentTVGame(
            CancellationToken token = default);

        Task<ImportOneGameResponse> ImportOneGame(string pgn);
    }
}