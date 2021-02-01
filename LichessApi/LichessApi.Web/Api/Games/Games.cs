using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Games.Request;
using LichessApi.Web.Api.Games.Response;
using Shouldly;

namespace LichessApi.Web.Api.Games
{
    public class Games : ApiBase
    {
        /// <summary>
        /// Download one game in either PGN or JSON format. If the game is ongoing, the 3 last moves are omitted.
        /// <see href="https://lichess.org/api#operation/gamePgn"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<Game> ExportOneGame(string gameId, ExportGameRequest request)
        {
            return API.Get<Game>(LichessApiConstants.EndPoints.ExportOneGame(gameId), request.BuildQueryParams());
        }

        /// <summary>
        /// Export ongoing game of a user
        /// Download the ongoing game, or the last game played, of a user. Available in either
        /// PGN or JSON format. If the game is ongoing, the 3 last moves are omitted.
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<Game> ExportOngoingGameOfUser(string username, ExportGameRequest request)
        {
            return API.Get<Game>(LichessApiConstants.EndPoints.ExportOngoingGame(username), request.BuildQueryParams());
        }

        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> ExportGames(string username, ExportGamesRequest request)
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// Export games of a user
        /// Download all games of any user in PGN or ndjson format.
        ///
        /// Games are sorted by reverse chronological order (most recent first)
        /// We recommend streaming the response, for it can be very long.
        /// https://lichess.org/@/german11 for instance has more than 320,000 games.
        ///
        /// The game stream is throttled, depending on who is making the request:
        ///
        /// Anonymous request: 20 games per second
        /// OAuth2 authenticated request: 30 games per second
        /// Authenticated, downloading your own games: 60 games per second
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<Game> ExportGamesByUser(string username, ExportGamesRequest request, [EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.ExportGamesByUser(username), HttpMethod.Get, parameters: request.BuildQueryParams(), token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<Game>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Export games by IDs
        /// Download games by IDs in PGN or ndjson format.
        /// Games are sorted by reverse chronological order(most recent first)
        /// The method is POST so a longer list of IDs can be sent in the request body.
        /// 300 IDs can be submitted.
        /// Ongoing games have their last 3 moves omitted, after move 5.
        /// <see href="https://lichess.org/api#operation/gamesExportIds"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<Game> ExportGamesByIds(ExportGamesByIdsRequest request, List<string> gameIds, [EnumeratorCancellation] CancellationToken token = default)
        {
            gameIds.ShouldNotBeEmpty();

            string strGameIds = String.Join(",", gameIds);

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.ExportGamesByIds(), HttpMethod.Post, request.BuildQueryParams(), body: strGameIds, token: token);

            await foreach (var o in StreamNdJson<Game>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Stream current games
        /// Stream the games played between a list of users, in real time.  Only games
        /// where both players are part of the list are included.
        ///
        /// Maximum number of users: 300.
        /// Games are streamed as ndjson, i.e.one JSON object per line.
        ///
        /// The method is POST so a longer list of IDs can be sent in the request body.
        /// <see href="https://lichess.org/api#operation/gamesByUsers"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<Game> StreamCurrentGames(List<string> userIds, [EnumeratorCancellation] CancellationToken token = default)
        {
            userIds.ShouldNotBeEmpty();

            string strUserIds = String.Join(",", userIds);

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.StreamCurrentGames(), HttpMethod.Post, null, body: strUserIds, token: token);

            await foreach (var o in StreamNdJson<Game>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Get ongoing games
        /// Get the ongoing games of the current user.Real-time and correspondence
        /// games are included. The most urgent games are listed first.
        /// <see href="https://lichess.org/api#operation/apiAccountPlaying"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OngoingGamesResponse> GetOngoingGames(int maxNumberOfGamesToFetch)
        {
            GetOngoingGamesRequest request = new GetOngoingGamesRequest
            {
                MaxNumberOfGamesToFetch = maxNumberOfGamesToFetch
            };

            return API.Get<OngoingGamesResponse>(LichessApiConstants.EndPoints.GetOngoingGames(), request.BuildQueryParams());
        }

        /// <summary>
        /// Get current TV games
        /// Get basic info about the best games being played for each speed and variant,
        /// but also computer games and bot games.
        /// <see href="https://lichess.org/api#operation/tvChannels"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<CurrentTVGameResponse> GetCurrentTVGames()
        {
            return API.Get<CurrentTVGameResponse>(LichessApiConstants.EndPoints.GetCurrentTvGames());
        }


        /// <summary>
        /// Stream current TV game
        /// Stream positions and moves of the current TV game in ndjson. A summary of the game
        /// is sent as a first message, and when the featured game changes.
        /// <see href="https://lichess.org/api#operation/tvFeed"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<StreamCurrentTVGameResponse> StreamCurrentTVGame([EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.StreamCurrentTvGame(), HttpMethod.Get, token: token);

            await foreach (var o in StreamNdJson<StreamCurrentTVGameResponse>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Import one game
        /// Import a game from PGN.See https://lichess.org/paste.
        /// Rate limiting: 200 games per hour for OAuth requests, 100 games per hour for
        /// anonymous requests.
        ///
        /// To broadcast ongoing games, consider pushing to a broadcast instead.
        /// <see href="https://lichess.org/api#operation/gameImport"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<ImportOneGameResponse> ImportOneGame(string pgn)
        {
            ImportOneGameRequest request = new ImportOneGameRequest
            {
                Pgn = pgn
            };

            return API.Post<ImportOneGameResponse>(LichessApiConstants.EndPoints.ImportOneGame(), null, body: request.BuildBodyParams());
        }
    }
}
