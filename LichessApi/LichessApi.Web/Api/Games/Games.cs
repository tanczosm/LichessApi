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
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<Game> ExportGamesByUser(string username, ExportGameRequest request, [EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.ExportGamesByUser(username), HttpMethod.Post, parameters: request.BuildQueryParams(), token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<Game>(response, token))
            {
                yield return o;
            }
        }

        /*
        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// 
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }
        */
    }
}
