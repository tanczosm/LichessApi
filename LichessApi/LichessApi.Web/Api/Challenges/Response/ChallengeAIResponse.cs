using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.Challenges.Response
{
    public class ChallengeAIResponse
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        [Newtonsoft.Json.JsonProperty("speed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed { get; set; }

        [Newtonsoft.Json.JsonProperty("perf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Perf { get; set; }

        [Newtonsoft.Json.JsonProperty("createdAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("lastMoveAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long LastMoveAt { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("players", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GamePlayers Players { get; set; }

        [Newtonsoft.Json.JsonProperty("opening", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Opening Opening { get; set; }

        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Moves { get; set; }

        [Newtonsoft.Json.JsonProperty("clock", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClockAlternate Clock { get; set; }
    }
}
