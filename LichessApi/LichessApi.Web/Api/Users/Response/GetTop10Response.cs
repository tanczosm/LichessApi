using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Users.Response
{
    public class GetTop10Response
    {
        [Newtonsoft.Json.JsonProperty("bullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Bullet { get; set; }

        [Newtonsoft.Json.JsonProperty("blitz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Blitz { get; set; }

        [Newtonsoft.Json.JsonProperty("rapid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Rapid { get; set; }

        [Newtonsoft.Json.JsonProperty("classical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Classical { get; set; }

        [Newtonsoft.Json.JsonProperty("ultraBullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> UltraBullet { get; set; }

        [Newtonsoft.Json.JsonProperty("chess960", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Chess960 { get; set; }

        [Newtonsoft.Json.JsonProperty("crazyhouse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> CrazyHouse { get; set; }

        [Newtonsoft.Json.JsonProperty("antichess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Antichess { get; set; }

        [Newtonsoft.Json.JsonProperty("atomic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Atomic { get; set; }

        [Newtonsoft.Json.JsonProperty("horde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> Horde { get; set; }

        [Newtonsoft.Json.JsonProperty("kingOfTheHill", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> KingOfTheHill { get; set; }

        [Newtonsoft.Json.JsonProperty("racingKings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> RacingKings { get; set; }

        [Newtonsoft.Json.JsonProperty("threeCheck", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<User> ThreeCheck { get; set; }
    }
}
