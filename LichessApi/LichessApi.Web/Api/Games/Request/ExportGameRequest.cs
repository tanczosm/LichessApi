using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Games.Request
{
    public class ExportGameRequest : RequestParams
    {
        /// <summary>
        /// Include the PGN moves
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Moves { get; set; } = true;

        /// <summary>
        /// Include the full PGN within the JSON response, in a pgn field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgnInJson", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool PgnInJson { get; set; }

        /// <summary>
        /// Include the PGN tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tags { get; set; } = true;

        /// <summary>
        /// Include clock comments in the PGN moves, when available.
        /// Example: 2. exd5 { [%clk 1:01:27] } e5 { [%clk 1:01:28] }
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clocks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Clocks { get; set; } = true;

        /// <summary>
        /// Include analysis evaluation comments in the PGN, when available.
        /// Example: 12. Bxf6 { [%eval 0.23] } a3 { [%eval -1.09] }
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Evals { get; set; } = true;

        /// <summary>
        /// Include the opening name.
        /// Example: [Opening "King's Gambit Accepted, King's Knight Gambit"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opening", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Opening { get; set; } = true;

        /// <summary>
        /// Insert textual annotations in the PGN about the opening, analysis variations, mistakes, and game termination.
        /// Example: Example: 5... g4? { (-0.98 → 0.60) Mistake. Best move was h6. } (5... h6 6. d4 Ne7 7. g3 d5 8. exd5 fxg3 9. hxg3 c6 10. dxc6)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("literate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Literate { get; set; }

        /// <summary>
        /// URL of a text file containing real names and ratings, to replace Lichess usernames and ratings in the PGN.
        /// Example: https://gist.githubusercontent.com/ornicar/6bfa91eb61a2dcae7bcd14cce1b2a4eb/raw/768b9f6cc8a8471d2555e47ba40fb0095e5fba37/gistfile1.txt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("players", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Players { get; set; }
    }
}
