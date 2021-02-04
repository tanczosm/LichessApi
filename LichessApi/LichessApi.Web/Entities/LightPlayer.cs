using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class LightPlayer
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Username { get; set; }

        [Newtonsoft.Json.JsonProperty("rating")]
        public int Rating { get; set; }

        [Newtonsoft.Json.JsonProperty("rank")] 
        public int Rank { get; set; }
    }
}
