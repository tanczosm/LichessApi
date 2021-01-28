using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Api.Challenges.Request
{
    public class DeclineChallengeRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChallengeDeclineReason Reason { get; set; }
    }
}
