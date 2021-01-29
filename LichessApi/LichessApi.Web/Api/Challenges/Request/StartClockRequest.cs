using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Challenges.Request
{
    public class StartClockRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("token1", Required = Newtonsoft.Json.Required.Always, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token1 { get; set; }

        [Newtonsoft.Json.JsonProperty("token2", Required = Newtonsoft.Json.Required.Always, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token2 { get; set; }
    }
}
