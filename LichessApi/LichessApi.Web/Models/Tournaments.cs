using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public class Tournaments
    {
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Number { get; set; }

        [Newtonsoft.Json.JsonProperty("best", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<TournamentBest> Best { get; set; }
    }
}
