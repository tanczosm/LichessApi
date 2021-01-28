using LichessApi.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Models
{
    public partial class PerfType
    {
        [Newtonsoft.Json.JsonProperty("chess960", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Chess960 { get; set; }

        [Newtonsoft.Json.JsonProperty("atomic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Atomic { get; set; }

        [Newtonsoft.Json.JsonProperty("racingKings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf RacingKings { get; set; }

        [Newtonsoft.Json.JsonProperty("ultraBullet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf UltraBullet { get; set; }

        [Newtonsoft.Json.JsonProperty("blitz", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Blitz { get; set; }

        [Newtonsoft.Json.JsonProperty("kingOfTheHill", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf KingOfTheHill { get; set; }

        [Newtonsoft.Json.JsonProperty("bullet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Bullet { get; set; }

        [Newtonsoft.Json.JsonProperty("correspondence", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Correspondence { get; set; }

        [Newtonsoft.Json.JsonProperty("horde", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Horde { get; set; }

        [Newtonsoft.Json.JsonProperty("puzzle", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Puzzle { get; set; }

        [Newtonsoft.Json.JsonProperty("classical", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Classical { get; set; }

        [Newtonsoft.Json.JsonProperty("rapid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Perf Rapid { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }
}
