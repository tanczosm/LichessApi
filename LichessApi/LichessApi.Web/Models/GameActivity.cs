using LichessApi.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public partial class GameActivity
    {
        [Newtonsoft.Json.JsonProperty("chess960", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Chess960 { get; set; }

        [Newtonsoft.Json.JsonProperty("atomic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Atomic { get; set; }

        [Newtonsoft.Json.JsonProperty("racingKings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score RacingKings { get; set; }

        [Newtonsoft.Json.JsonProperty("ultraBullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score UltraBullet { get; set; }

        [Newtonsoft.Json.JsonProperty("blitz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Blitz { get; set; }

        [Newtonsoft.Json.JsonProperty("kingOfTheHill", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score KingOfTheHill { get; set; }

        [Newtonsoft.Json.JsonProperty("bullet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Bullet { get; set; }

        [Newtonsoft.Json.JsonProperty("correspondence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Correspondence { get; set; }

        [Newtonsoft.Json.JsonProperty("horde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Horde { get; set; }

        [Newtonsoft.Json.JsonProperty("puzzle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Puzzle { get; set; }

        [Newtonsoft.Json.JsonProperty("classical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Classical { get; set; }

        [Newtonsoft.Json.JsonProperty("rapid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Rapid { get; set; }
    }
}
