using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Api.BulkPairings.Request;
using LichessApi.Web.Api.BulkPairings.Response;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.BulkPairings
{
    public class BulkPairings : ApiBase, IBulkPairings
    {
        /// <summary>
        /// View upcoming bulk pairings
        /// Get a list of upcoming bulk pairings you created.
        ///
        /// Only bulk pairings that are scheduled in the future, or that have a clock start scheduled in the future, are listed.
        ///
        /// Bulk pairings are deleted from the server after the pairings are done and the clocks have started.
        /// 
        /// <see href="https://lichess.org/api#operation/bulkPairingGet"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<BulkPairingResponse>> ViewUpcomingBulkPairings()
        {
            return API.Get<List<BulkPairingResponse>>(LichessApiConstants.EndPoints.ViewUpcomingBulkPairings());
        }

        /// <summary>
        /// Create a bulk pairing
        /// Schedule many games up to 24h in advance.
        ///
        /// OAuth tokens are required for all paired players, with the challenge:write scope.
        ///
        /// You can schedule up to 500 games every 10 minutes.Contact us if you need higher limits.
        ///
        ///
        /// The entire bulk is rejected if:
        /// - a token is missing
        /// - a token is present more than once
        /// - a token lacks the challenge:write scope
        /// - a user account is closed
        /// - a user is paired more than once
        ///
        /// Partial bulks are never created. Either it all fails, or it all succeeds. When it fails, it does so with an
        /// error message explaining the issue.
        /// 
        /// <see href="https://lichess.org/api#operation/bulkPairingGet"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<BulkPairingResponse> CreateBulkPairing(BulkPairingRequest request)
        {
            return API.Post<BulkPairingResponse>(LichessApiConstants.EndPoints.CreateBulkPairing(), request.BuildQueryParams());
        }


        /// <summary>
        /// Cancel a bulk pairing
        ///
        /// Cancel and delete a bulk pairing that is scheduled in the future.
        /// If the games have already been created, then this does nothing.
        /// Canceling a bulk pairing does not refund the rate limit cost of that bulk pairing.
        /// 
        /// <see href="https://lichess.org/api#operation/bulkPairingDelete"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> CancelBulkPairing(string bulkPairingId)
        {
            return API.Delete<OkResponse>(LichessApiConstants.EndPoints.CancelBulkPairing(bulkPairingId));
        }


    }
}
