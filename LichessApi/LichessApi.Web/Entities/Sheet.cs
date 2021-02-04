using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Sheet
    {
        [Newtonsoft.Json.JsonProperty("scores")]
        public List<Dictionary<string,int>> Scores { get; set; }
        
        [Newtonsoft.Json.JsonProperty("total")] 
        public int Total { get; set; }

        [Newtonsoft.Json.JsonProperty("fire")] 
        public bool Fire { get; set; }
    }
}
