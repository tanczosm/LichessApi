using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class ClockAlternate
    {
        [Newtonsoft.Json.JsonProperty("initial", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Initial { get; set; }

        [Newtonsoft.Json.JsonProperty("increment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Increment { get; set; }

        [Newtonsoft.Json.JsonProperty("totalTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TotalTime { get; set; }

    }
}
