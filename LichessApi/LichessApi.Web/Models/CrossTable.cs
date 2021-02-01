using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public class CrossTable
    {
        [Newtonsoft.Json.JsonProperty("users", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Dictionary<string, double> Users { get; set; }

        [Newtonsoft.Json.JsonProperty("nbGames", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfGames { get; set; }

        [Newtonsoft.Json.JsonProperty("matchup", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CrosstableMatchup Matchup { get; set; }
        
    }
}
