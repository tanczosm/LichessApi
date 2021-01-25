using LichessNet.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Api.ArenaTournaments.Request
{
    public class ArenaTournamentRequest
    {
        /// <summary>The tournament name. Leave empty to get a random Grandmaster name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Clock initial time in minutes</summary>
        [Newtonsoft.Json.JsonProperty("clockTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, 60D)]
        public double ClockTime { get; set; }

        /// <summary>Clock increment in seconds</summary>
        [Newtonsoft.Json.JsonProperty("clockIncrement", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 60)]
        public int ClockIncrement { get; set; }

        /// <summary>How long the tournament lasts, in minutes</summary>
        [Newtonsoft.Json.JsonProperty("minutes", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 360)]
        public int Minutes { get; set; }

        /// <summary>How long to wait before starting the tournament, from now, in minutes</summary>
        [Newtonsoft.Json.JsonProperty("waitMinutes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, 360)]
        public int WaitMinutes { get; set; } = 5;

        /// <summary>Timestamp to start the tournament at a given date and time. Overrides the `waitMinutes` setting</summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StartDate { get; set; }

        /// <summary>The variant to use in tournament games</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GameVariant Variant { get; set; } = GameVariant.Standard;

        /// <summary>Games are rated and impact players ratings</summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Rated { get; set; } = true;

        /// <summary>Custom initial position (in FEN) for all games of the tournament. Must be a legal chess position. Only works with standard chess, not variants (except Chess960).</summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>Whether the players can use berserk</summary>
        [Newtonsoft.Json.JsonProperty("berserkable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Berserkable { get; set; } = true;

        /// <summary>After 2 wins, consecutive wins grant 4 points instead of 2.</summary>
        [Newtonsoft.Json.JsonProperty("streakable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Streakable { get; set; } = true;

        /// <summary>Whether the players can discuss in a chat</summary>
        [Newtonsoft.Json.JsonProperty("hasChat", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasChat { get; set; } = true;

        /// <summary>Anything you want to tell players about the tournament</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Make the tournament private, and restrict access with a password</summary>
        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>Restrict entry to members of a team.
        /// 
        /// The teamId is the last part of a team URL, e.g. https://lichess.org/team/coders has teamId = `coders`.
        /// 
        /// Leave empty to let everyone join the tournament.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conditions.teamMember.teamId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConditionsTeamMemberTeamId { get; set; }

        /// <summary>Minimum rating to join. Leave empty to let everyone join the tournament.</summary>
        [Newtonsoft.Json.JsonProperty("conditions.minRating.rating", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConditionsMinRatingRating { get; set; }

        /// <summary>Maximum rating to join. Based on best rating reached in the last 7 days. Leave empty to let everyone join the tournament.</summary>
        [Newtonsoft.Json.JsonProperty("conditions.maxRating.rating", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConditionsMaxRatingRating { get; set; }

        /// <summary>Minimum number of rated games required to join.</summary>
        [Newtonsoft.Json.JsonProperty("conditions.nbRatedGame.nb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConditionsNbRatedGameNb { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }
}
