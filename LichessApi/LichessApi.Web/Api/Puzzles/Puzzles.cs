using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Puzzles.Response;
using LichessApi.Web.Entities;
using Shouldly;

namespace LichessApi.Web.Api.Puzzles
{
    public class Puzzles : ApiBase, IPuzzles
    {

        /// <summary>
        /// Get your puzzle activity
        /// Download your puzzle activity in ndjson format.
        /// Puzzle activity is sorted by reverse chronological order (most recent first)
        ///
        /// We recommend streaming the response, for it can be very long.
        /// <see href="https://lichess.org/api#operation/apiPuzzleActivity"/></see>
        /// </summary>
        /// <param name="maxPuzzles">How many entries to download. Leave set to zero to download all activity.</param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<PuzzleActivity> GetPuzzleActivity(int maxPuzzles = 0, [EnumeratorCancellation] CancellationToken token = default)
        {
            maxPuzzles.ShouldBeGreaterThanOrEqualTo(0);

            Dictionary<string, string> request = 
                new Dictionary<string, string>()
                {
                    {"max", maxPuzzles == 0 ? null : maxPuzzles.ToString()}
                };

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.GetPuzzleActivity(), HttpMethod.Get, request, token: token);

            await foreach (var o in StreamNdJson<PuzzleActivity>(response, token))
            {
                yield return o;
            }
        }


        /// <summary>
        ///
        /// <see href="https://lichess.org/api#operation/apiSimul"/></see>
        /// </summary>
        /// <param name="days">1 or greater, How many days to look back when aggregating puzzle results. 30 is sensible.</param>
        /// <returns></returns>
        public Task<PuzzleDashboardResponse> GetPuzzleDashboard(int days = 1)
        {
            return API.Get<PuzzleDashboardResponse>(LichessApiConstants.EndPoints.GetPuzzleDashboard(days.ToString()));
        }
    }
}
