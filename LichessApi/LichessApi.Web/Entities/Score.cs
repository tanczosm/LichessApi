using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Score
    {
        [Newtonsoft.Json.JsonProperty("win", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Win { get; set; }

        [Newtonsoft.Json.JsonProperty("loss", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Loss { get; set; }

        [Newtonsoft.Json.JsonProperty("draw", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Draw { get; set; }

        [Newtonsoft.Json.JsonProperty("rp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Rp rp { get; set; }
    }
}
