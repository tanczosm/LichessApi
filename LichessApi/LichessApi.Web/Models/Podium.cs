using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using Newtonsoft.Json;

namespace LichessApi.Web.Models
{
    public class Podium
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("sheet")]
        public Sheet Sheet { get; set; }

        [JsonProperty("nb")]
        public Nb Nb { get; set; }

        [JsonProperty("performance")]
        public int Performance { get; set; }
    }
}
