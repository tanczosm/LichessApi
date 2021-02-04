using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class FeaturedGame
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("fen")] 
        public string Fen { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Color { get; set; }

        [Newtonsoft.Json.JsonProperty("lastMove")] 
        public string LastMove { get; set; }

        [Newtonsoft.Json.JsonProperty("white")] 
        public LightPlayer White { get; set; }

        [Newtonsoft.Json.JsonProperty("black")] 
        public LightPlayer Black { get; set; }
    }
}
