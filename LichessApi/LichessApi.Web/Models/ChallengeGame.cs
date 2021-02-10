using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class ChallengeGame
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Variant Variant { get; set; }

        [Newtonsoft.Json.JsonProperty("speed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed { get; set; }

        [Newtonsoft.Json.JsonProperty("perf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GameVariant Perf { get; set; }

        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("initialFen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InitialFen { get; set; }

        [Newtonsoft.Json.JsonProperty("fen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fen { get; set; }

        [Newtonsoft.Json.JsonProperty("player", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Color PlayerColor { get; set; }

        [Newtonsoft.Json.JsonProperty("turns", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Turns { get; set; }

        [Newtonsoft.Json.JsonProperty("startedAtTurn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StartedAtTurn { get; set; }

        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Source { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChallengeStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("createdAt")]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }


    }
}
