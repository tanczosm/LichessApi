using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Simul
    {
        [Newtonsoft.Json.JsonProperty("fullName")]
        public string FullName { get; set; }

        [Newtonsoft.Json.JsonProperty("host")]
        public LightUser Host { get; set; }

        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("isCreated")]
        public bool IsCreated { get; set; }

        [Newtonsoft.Json.JsonProperty("isFinished")]
        public bool IsFinished { get; set; }

        [Newtonsoft.Json.JsonProperty("isRunning")]
        public bool IsRunning { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("nbApplicants")]
        public int NumberOfApplicants { get; set; }

        [Newtonsoft.Json.JsonProperty("nbPairings")]
        public int NumberOfPairings { get; set; }

        [Newtonsoft.Json.JsonProperty("text")]
        public string Text { get; set; }

        [Newtonsoft.Json.JsonProperty("variants")]
        public List<Variant> Variants { get; set; }
    }
}
