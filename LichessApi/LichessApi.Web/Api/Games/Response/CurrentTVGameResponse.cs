using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.Games.Response
{
    public class CurrentTVGameResponse
    {
        [Newtonsoft.Json.JsonProperty("Bot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Bot { get; set; }

        [Newtonsoft.Json.JsonProperty("Blitz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Blitz { get; set; }

        [Newtonsoft.Json.JsonProperty("Racing Kings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame RacingKings { get; set; }

        [Newtonsoft.Json.JsonProperty("UltraBullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame UltraBullet { get; set; }

        [Newtonsoft.Json.JsonProperty("Bullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Bullet { get; set; }

        [Newtonsoft.Json.JsonProperty("Classical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Classical { get; set; }

        [Newtonsoft.Json.JsonProperty("Three-check", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame ThreeCheck { get; set; }

        [Newtonsoft.Json.JsonProperty("Antichess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Antichess { get; set; }

        [Newtonsoft.Json.JsonProperty("Computer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Computer { get; set; }

        [Newtonsoft.Json.JsonProperty("Horde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Horde { get; set; }

        [Newtonsoft.Json.JsonProperty("Rapid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Rapid { get; set; }

        [Newtonsoft.Json.JsonProperty("Atomic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Atomic { get; set; }

        [Newtonsoft.Json.JsonProperty("Crazyhouse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Crazyhouse { get; set; }

        [Newtonsoft.Json.JsonProperty("Chess960", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame Chess960 { get; set; }

        [Newtonsoft.Json.JsonProperty("King of the Hill", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame KingoftheHill { get; set; }

        [Newtonsoft.Json.JsonProperty("Top Rated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TVGame TopRated { get; set; }
    }
}
