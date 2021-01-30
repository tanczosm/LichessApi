using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;
using LichessApi.Web.Models;

namespace LichessApi.Web.Entities
{
    public class LightGame
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /*
        public ??? WhitePlayer { get; set; }
        public ??? BlackPlayer { get; set; }
        public GameStatus Status { get; set; }
        */
    }
}
