using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Games.Request
{
    public class OngoingGamesRequest
    {
        [Newtonsoft.Json.JsonProperty("nb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int MaxNumberOfGamesToFetch { get; set; }
    }
}
