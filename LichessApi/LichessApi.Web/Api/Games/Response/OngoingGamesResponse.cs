using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.Games.Response
{
    public class OngoingGamesResponse
    {
        [Newtonsoft.Json.JsonProperty("nowPlaying", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<GameInProgress> NowPlaying { get; set; }
    }
}
