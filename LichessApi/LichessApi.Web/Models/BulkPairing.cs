using System;
using System.Collections.Generic;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class BulkPairing
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("games")]
        public List<BulkGame> Games { get; set; }

        [Newtonsoft.Json.JsonProperty("variant")]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        [Newtonsoft.Json.JsonProperty("clock")]
        public Clock Clock { get; set; }

        [Newtonsoft.Json.JsonProperty("pairAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime PairAt { get; set; }

        [Newtonsoft.Json.JsonProperty("pairedAt")]
        public object PairedAt { get; set; }  // Not sure what this is

        [Newtonsoft.Json.JsonProperty("Rated")]
        public bool Rated { get; set; }

        [Newtonsoft.Json.JsonProperty("startClocksAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime StartClocksAt { get; set; }

        [Newtonsoft.Json.JsonProperty("scheduledAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime ScheduledAt { get; set; }
    }
}
