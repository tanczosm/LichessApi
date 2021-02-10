using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LichessApi.Web.Entities
{
    public class PuzzleActivity
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("ratingDiff")]
        public int RatingDiff { get; set; }

        [JsonProperty("puzzleRating")]
        public int PuzzleRating { get; set; }

    }
}
