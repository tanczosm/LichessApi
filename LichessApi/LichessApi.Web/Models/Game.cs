using System;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class Game
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameSpeed? Speed { get; set; }

        [Newtonsoft.Json.JsonProperty("perf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PerfType Perf { get; set; }

        [Newtonsoft.Json.JsonProperty("createdAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("lastMoveAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime LastMoveAt { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public GameStatus Status { get; set; }

        [Newtonsoft.Json.JsonProperty("players", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GamePlayers Players { get; set; }

        [Newtonsoft.Json.JsonProperty("initialFen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InitialFen { get; set; }

        [Newtonsoft.Json.JsonProperty("winner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Winner { get; set; }

        [Newtonsoft.Json.JsonProperty("opening", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Opening Opening { get; set; }

        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Moves { get; set; }

        [Newtonsoft.Json.JsonProperty("pgn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pgn { get; set; }

        [Newtonsoft.Json.JsonProperty("daysPerTurn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Days { get; set; }

        [Newtonsoft.Json.JsonProperty("analysis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Analysis { get; set; }

        [Newtonsoft.Json.JsonProperty("tournament", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TournamentId { get; set; }

        [Newtonsoft.Json.JsonProperty("clock", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClockAlternate Clock { get; set; }
    }
}
