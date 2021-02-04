using Newtonsoft.Json; 
namespace LichessApi.Web.Api.Puzzles.Response{ 

    public class AdvancedPawn    
    {
        [JsonProperty("results")]
        public Results Results { get; set; } 

        [JsonProperty("theme")]
        public string Theme { get; set; } 
    }

}