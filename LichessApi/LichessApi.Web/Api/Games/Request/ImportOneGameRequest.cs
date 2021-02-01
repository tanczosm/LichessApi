using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Games.Request
{
    public class ImportOneGameRequest : RequestParams
    {
        /// <summary>
        /// The PGN. It can contain only one game. Most standard tags are supported.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pgn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pgn { get; set; }
    }
}
