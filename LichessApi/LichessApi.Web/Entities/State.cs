using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public partial class State
    {
        /// <summary>Current moves in UCI format</summary>
        [Newtonsoft.Json.JsonProperty("moves", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Moves { get; set; }

        /// <summary>Integer of milliseconds White has left on the clock</summary>
        [Newtonsoft.Json.JsonProperty("wtime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Wtime { get; set; }

        /// <summary>Integer of milliseconds Black has left on the clock</summary>
        [Newtonsoft.Json.JsonProperty("btime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Btime { get; set; }

        /// <summary>Integer of White Fisher increment.</summary>
        [Newtonsoft.Json.JsonProperty("winc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Winc { get; set; }

        /// <summary>Integer of Black Fisher increment.</summary>
        [Newtonsoft.Json.JsonProperty("binc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Binc { get; set; }

        /// <summary>Game status code. https://github.com/ornicar/scalachess/blob/0a7d6f2c63b1ca06cd3c958ed3264e738af5c5f6/src/main/scala/Status.scala#L16-L28</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>Color of the winner, if any</summary>
        [Newtonsoft.Json.JsonProperty("winner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Winner { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }
}
