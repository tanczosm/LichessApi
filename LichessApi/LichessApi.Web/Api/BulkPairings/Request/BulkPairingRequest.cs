using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Api.BulkPairings.Request
{
    public class BulkPairingRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("players")]
        public string Players { get; set; }

        [Newtonsoft.Json.JsonProperty("clock.limit")]
        public int ClockLimit { get; set; }

        [Newtonsoft.Json.JsonProperty("clock.increment")]
        public int ClockIncrement { get; set; }

        [Newtonsoft.Json.JsonProperty("pairAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime PairAt { get; set; }

        [Newtonsoft.Json.JsonProperty("startClocksAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime StartClocksAt { get; set; }

        [Newtonsoft.Json.JsonProperty("rated")]
        public bool Rated { get; set; }

        [Newtonsoft.Json.JsonProperty("variant")]
        public GameVariant Variant { get; set; } = GameVariant.Standard;
    }
}
