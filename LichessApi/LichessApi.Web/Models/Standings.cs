using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public class Standings
    {
        [Newtonsoft.Json.JsonProperty("page")]
        public int Page { get; set; }

        [Newtonsoft.Json.JsonProperty("players")]
        public List<StandingsPlayer> Players { get; set; }
    }
}
