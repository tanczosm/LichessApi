using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Models
{
    public class StandingsPlayer
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("rank")]
        public int Rank { get; set; }

        [Newtonsoft.Json.JsonProperty("rating")]
        public int Rating { get; set; }

        [Newtonsoft.Json.JsonProperty("score")]
        public int Score { get; set; }

        [Newtonsoft.Json.JsonProperty("sheet")]
        public Sheet Sheet { get; set; }
    }
}
