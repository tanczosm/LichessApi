using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class DuelPlayer
    {
        [Newtonsoft.Json.JsonProperty("n")]
        public string Username { get; set; }

        [Newtonsoft.Json.JsonProperty("r")]
        public int Rating { get; set; }

        [Newtonsoft.Json.JsonProperty("k")]
        public int K { get; set; }
    }
}
