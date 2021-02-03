using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.BulkPairings.Response
{
    public class BulkPairingResponse
    {
        [Newtonsoft.Json.JsonProperty("bulks")]
        public List<BulkPairing> Bulks { get; set; }
    }
}
