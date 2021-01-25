using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Models
{
    class RatingHistory
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name;

        [Newtonsoft.Json.JsonProperty("points")]
        public List<RatingEntry> Points;
    }
}
