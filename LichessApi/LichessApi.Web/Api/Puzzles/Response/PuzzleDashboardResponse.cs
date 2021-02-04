using Newtonsoft.Json; 

namespace LichessApi.Web.Api.Puzzles.Response{ 

    public class PuzzleDashboardResponse
    {
        [JsonProperty("days")]
        public int Days { get; set; } 

        [JsonProperty("global")]
        public Global Global { get; set; } 

        [JsonProperty("themes")]
        public Themes Themes { get; set; } 
    }

}