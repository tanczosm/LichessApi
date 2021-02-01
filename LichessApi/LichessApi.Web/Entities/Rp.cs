using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Rp
    {
        [Newtonsoft.Json.JsonProperty("before", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Before { get; set; }

        [Newtonsoft.Json.JsonProperty("before", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int After { get; set; }
    }
}
