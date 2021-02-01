using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Models
{
    public class CorrespondenceMoves
    {
        [Newtonsoft.Json.JsonProperty("nb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Number { get; set; }

        [Newtonsoft.Json.JsonProperty("games", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<LightGame> Games { get; set; }
    }
}
