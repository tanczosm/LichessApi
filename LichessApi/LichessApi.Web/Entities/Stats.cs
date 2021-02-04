using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LichessApi.Web.Entities
{
    public class Stats
    {
        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("moves")]
        public int Moves { get; set; }

        [JsonProperty("whiteWins")]
        public int WhiteWins { get; set; }

        [JsonProperty("blackWins")]
        public int BlackWins { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("berserks")]
        public int Berserks { get; set; }

        [JsonProperty("averageRating")]
        public int AverageRating { get; set; }
    }
}
