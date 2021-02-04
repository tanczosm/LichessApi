using Newtonsoft.Json; 
namespace LichessApi.Web.Api.Puzzles.Response{ 

    public class Themes    
    {
        [JsonProperty("advancedPawn")]
        public AdvancedPawn AdvancedPawn { get; set; } 

        [JsonProperty("anastasiaMate")]
        public AnastasiaMate AnastasiaMate { get; set; } 
    }

}