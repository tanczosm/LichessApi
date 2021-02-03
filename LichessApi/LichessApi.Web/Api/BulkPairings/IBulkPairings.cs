using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Api.BulkPairings.Request;
using LichessApi.Web.Api.BulkPairings.Response;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.BulkPairings
{
    public interface IBulkPairings
    {
        void Initialize(IApiConnector api);

        public Task<List<BulkPairingResponse>> ViewUpcomingBulkPairings();
        public Task<BulkPairingResponse> CreateBulkPairing(BulkPairingRequest request);
        public Task<OkResponse> CancelBulkPairing(string bulkPairingId);
    }
}