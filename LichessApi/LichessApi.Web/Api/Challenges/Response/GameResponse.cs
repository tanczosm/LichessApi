using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.Challenges.Response
{
    public class GameResponse
    {
        [Newtonsoft.Json.JsonProperty("game", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChallengeGame Game { get; set; }

    }
}
