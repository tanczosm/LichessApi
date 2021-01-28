using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Api.Challenges.Response
{
    public class GameResponse
    {
        [Newtonsoft.Json.JsonProperty("fullId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullId { get; set; }

        [Newtonsoft.Json.JsonProperty("gameId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GameId { get; set; }

        [Newtonsoft.Json.JsonProperty("fen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fen { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Color Color { get; set; } = Color.Random;

        [Newtonsoft.Json.JsonProperty("lastMove", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastMove { get; set; }

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        [Newtonsoft.Json.JsonProperty("speed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed { get; set; }

        [Newtonsoft.Json.JsonProperty("perf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Perf { get; set; }

        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("opponent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LightUser Opponent { get; set; }

        [Newtonsoft.Json.JsonProperty("isMyTurn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsMyTurn { get; set; }

    }
}
