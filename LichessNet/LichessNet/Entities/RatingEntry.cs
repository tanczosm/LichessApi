using LichessNet.Util.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Entities
{
    [JsonConverter(typeof(RatingEntryConverter))]
    public class RatingEntry
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Rating { get; set; }
    }
}
