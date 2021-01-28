using LichessApi.Web.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web;

namespace LichessApi.Api.Challenges.Request
{
    public partial class CreateChallengeRequest : RequestParams
    {
        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        /// <summary>Clock initial time in seconds</summary>
        [Newtonsoft.Json.JsonProperty("clock.limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, Required = Newtonsoft.Json.Required.Default)]
        public int? ClockLimit { get; set; }

        /// <summary>Clock increment in seconds</summary>
        [Newtonsoft.Json.JsonProperty("clock.increment", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, Required = Newtonsoft.Json.Required.Default)]
        public int? ClockIncrement { get; set; }

        [Newtonsoft.Json.JsonProperty("days", Required = Newtonsoft.Json.Required.Default)]
        public int Days { get; set; }

        /// <summary>Timestamp in milliseconds to start the tournament at a given date and time. By default, it starts 10 minutes after creation.</summary>
        [Newtonsoft.Json.JsonProperty("startsAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StartsAt { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Color Color { get; set; } = Color.Random;

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        [Newtonsoft.Json.JsonProperty("fen", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fen { get; set; }

    }
 
}
