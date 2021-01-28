using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Models
{
    public class GamePlayer
    {
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LightUser User { get; set; }

        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Rating { get; set; }

        [Newtonsoft.Json.JsonProperty("ratingDiff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RatingDiff { get; set; }
    }
}
