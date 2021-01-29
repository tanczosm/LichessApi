using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LichessApi.Web.Entities
{
    public partial class Clock
    {
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Limit { get; set; }

        [Newtonsoft.Json.JsonProperty("increment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Increment { get; set; }

        [Newtonsoft.Json.JsonProperty("show", NullValueHandling = NullValueHandling.Ignore)]
        public string Show { get; set; } = "";

        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }
    }
}
