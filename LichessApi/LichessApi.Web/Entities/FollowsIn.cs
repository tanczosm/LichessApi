using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class FollowsOut
    {
        [Newtonsoft.Json.JsonProperty("ids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }
    }
}
