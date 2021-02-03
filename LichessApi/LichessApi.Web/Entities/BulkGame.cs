using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class BulkGame
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("black")]
        public string BlackPlayer { get; set; }

        [Newtonsoft.Json.JsonProperty("white")]
        public string WhitePlayer { get; set; }
    }
}
