using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Follows
    {
        [Newtonsoft.Json.JsonProperty("in", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FollowsIn In { get; set; }

        [Newtonsoft.Json.JsonProperty("out", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FollowsOut Out { get; set; }

    }
}
