using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Round
    {
        [Newtonsoft.Json.JsonProperty("at")]
        public DateTime StartsAt { get; set; }

        [Newtonsoft.Json.JsonProperty("in")]
        public int In { get; set; }
    }
}
