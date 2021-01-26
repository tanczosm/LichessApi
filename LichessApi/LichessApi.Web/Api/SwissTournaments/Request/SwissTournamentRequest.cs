using LichessApi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Api.SwissTournaments.Request
{
    public partial class SwissTournamentRequest
    {
        /// <summary>The tournament name. Leave empty to get a random Grandmaster name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Clock initial time in seconds</summary>
        [Newtonsoft.Json.JsonProperty("clock.limit", Required = Newtonsoft.Json.Required.Always)]
        public double ClockLimit { get; set; }

        /// <summary>Clock increment in seconds</summary>
        [Newtonsoft.Json.JsonProperty("clock.increment", Required = Newtonsoft.Json.Required.Always)]
        public int ClockIncrement { get; set; }

        /// <summary>Maximum number of rounds to play</summary>
        [Newtonsoft.Json.JsonProperty("nbRounds", Required = Newtonsoft.Json.Required.Always)]
        public int NbRounds { get; set; } = 8;

        /// <summary>Timestamp in milliseconds to start the tournament at a given date and time. By default, it starts 10 minutes after creation.</summary>
        [Newtonsoft.Json.JsonProperty("startsAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StartsAt { get; set; }

        /// <summary>How long to wait between each round, in seconds.
        /// 
        /// Set to 99999999 to manually schedule each round from the tournament UI.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roundInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoundInterval { get; set; }

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        /// <summary>Anything you want to tell players about the tournament</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        /// <summary>Who can read and write in the chat.
        /// - 0  = No-one
        /// - 10 = Only team leaders
        /// - 20 = Only team members
        /// - 30 = All Lichess players
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatFor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ChatFor { get; set; } = 20D;

    }
}
