using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Quote
    {
        [Newtonsoft.Json.JsonProperty("author")]
        public string Author { get; set; }

        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }
    }
}
