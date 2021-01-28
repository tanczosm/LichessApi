using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public class GamePlayers
    {
        [Newtonsoft.Json.JsonProperty("white", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GamePlayer White { get; set; }

        [Newtonsoft.Json.JsonProperty("black", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GamePlayer Black { get; set; }

    }
}
