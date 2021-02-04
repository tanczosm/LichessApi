using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class TournamentPlayer
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }
    }
}
