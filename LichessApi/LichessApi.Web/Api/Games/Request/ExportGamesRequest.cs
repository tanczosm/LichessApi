using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;
using LichessApi.Web.Models;
using LichessApi.Web.Util.Converters;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Api.Games.Request
{
    public class ExportGamesRequest : RequestParams
    {
        /// <summary>
        /// Download games played since this timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("since", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(MillisecondEpochConverter))]
        public DateTime Since { get; set; }

        /// <summary>
        /// Download games played until this timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("until", Required = Newtonsoft.Json.Required.DisallowNull,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(MillisecondEpochConverter))]
        public DateTime Until { get; set; } = DateTime.Now;

        /// <summary>
        /// How many games to download. Leave null to download all games.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Max { get; set; }

        /// <summary>
        /// [Filter] Only games played against this opponent
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Vs { get; set; }

        /// <summary>
        /// [Filter] Only rated (true) or casual (false) games
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Rated { get; set; }

        /// <summary>
        /// Enum: "ultraBullet" "bullet" "blitz" "rapid" "classical" "correspondence" "chess960" "crazyhouse" "antichess" "atomic" "horde" "kingOfTheHill" "racingKings" "threeCheck"
        //  [Filter] Only games in these speeds or variants.
        //  Multiple perf types can be specified, separated by a comma.
        //  Example: blitz,rapid,classical
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perfType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PerfType { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Color { get; set; }

        [Newtonsoft.Json.JsonProperty("analysed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Analyzed { get; set; }

        [Newtonsoft.Json.JsonProperty("ongoing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Ongoing { get; set; }

        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.DisallowNull,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Moves { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("pgnInJson", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool PgnInJson { get; set; }

        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tags { get; set; } = true;

        [Newtonsoft.Json.JsonProperty("clocks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Clocks { get; set; }

        [Newtonsoft.Json.JsonProperty("evals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Evals { get; set; }

        [Newtonsoft.Json.JsonProperty("opening", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Opening { get; set; }

        /// <summary>
        /// URL of a text file containing real names and ratings, to replace Lichess usernames and ratings in the PGN.
        /// Example: https://gist.githubusercontent.com/ornicar/6bfa91eb61a2dcae7bcd14cce1b2a4eb/raw/768b9f6cc8a8471d2555e47ba40fb0095e5fba37/gistfile1.txt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("players", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Players { get; set; }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
