using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class StreamTVGameDescription
    {
        [Newtonsoft.Json.JsonProperty("gameId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GameId { get; set; }

        [Newtonsoft.Json.JsonProperty("orientation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Orientation { get; set; }

        [Newtonsoft.Json.JsonProperty("players", Required = Newtonsoft.Json.Required.DisallowNull,
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<GamePlayer> Players { get; set; }

        [Newtonsoft.Json.JsonProperty("fen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fen { get; set; }
    }
}
