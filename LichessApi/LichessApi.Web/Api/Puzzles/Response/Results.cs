using Newtonsoft.Json; 

namespace LichessApi.Web.Api.Puzzles.Response
{ 

    public class Results    
    {
        [JsonProperty("firstWins")]
        public int FirstWins { get; set; } 

        [JsonProperty("nb")]
        public int Nb { get; set; } 

        [JsonProperty("performance")]
        public int Performance { get; set; } 

        [JsonProperty("puzzleRatingAvg")]
        public int PuzzleRatingAvg { get; set; } 

        [JsonProperty("replayWins")]
        public int ReplayWins { get; set; } 
    }

}