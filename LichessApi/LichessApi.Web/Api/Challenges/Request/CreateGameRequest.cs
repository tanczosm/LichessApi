using LichessApi.Web.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web;

namespace LichessApi.Api.Challenges.Request
{
    public partial class CreateGameRequest : CreateChallengeRequest
    {
        [Newtonsoft.Json.JsonProperty("acceptsByToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string acceptByToken { get; set; } = "";
    }
}
