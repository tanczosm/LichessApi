using Newtonsoft.Json; 
namespace LichessApi.Web.Api.Puzzles.Response{ 

    public class Global    
    {
        [JsonProperty("firstWins")]
        public int FirstWins { get; set; } 

        [JsonProperty("nb")]
        public int Number { get; set; } 

        [JsonProperty("performance")]
        public int Performance { get; set; } 

        [JsonProperty("puzzleRatingAvg")]
        public int PuzzleRatingAvg { get; set; } 

        [JsonProperty("replayWins")]
        public int ReplayWins { get; set; } 
    }

}