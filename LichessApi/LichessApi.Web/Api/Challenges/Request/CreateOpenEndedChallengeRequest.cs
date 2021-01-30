using LichessApi.Web.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web;

namespace LichessApi.Web.Api.Challenges.Request
{
    public partial class CreateOpenEndedChallengeRequest : RequestParams
    {
        /// <summary>Clock initial time in seconds - Set to null for correspondence game</summary>
        [Newtonsoft.Json.JsonProperty("clock.limit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, Required = Newtonsoft.Json.Required.Default)]
        public int? ClockLimit { get; set; }

        /// <summary>Clock increment in seconds - Set to null for correspondence game</summary>
        [Newtonsoft.Json.JsonProperty("clock.increment", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, Required = Newtonsoft.Json.Required.Default)]
        public int? ClockIncrement { get; set; }

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        [Newtonsoft.Json.JsonProperty("fen", Required = Newtonsoft.Json.Required.DisallowNull,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Fen { get; set; }

    }
 
}
