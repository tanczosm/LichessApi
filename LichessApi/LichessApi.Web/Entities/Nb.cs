using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LichessApi.Web.Entities
{
    public class Nb
    {
        [JsonProperty("game")]
        public int Game { get; set; }

        [JsonProperty("beserk")]
        public int Beserk { get; set; }

        [JsonProperty("win")]
        public int Win { get; set; }
    }
}
