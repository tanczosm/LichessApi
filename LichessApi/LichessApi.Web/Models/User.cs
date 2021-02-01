using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Entities
{
    public partial class User
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Username { get; set; }

        [Newtonsoft.Json.JsonProperty("online", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Online { get; set; }

        [Newtonsoft.Json.JsonProperty("perfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Performances Performances { get; set; }

        [Newtonsoft.Json.JsonProperty("createdAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("disabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Disabled { get; set; }

        [Newtonsoft.Json.JsonProperty("tosViolation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool TosViolation { get; set; }

        [Newtonsoft.Json.JsonProperty("booster", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Booster { get; set; }

        [Newtonsoft.Json.JsonProperty("profile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Profile Profile { get; set; }

        [Newtonsoft.Json.JsonProperty("seenAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(LichessApi.Web.Util.Converters.MillisecondEpochConverter))]
        public DateTime SeenAt { get; set; }

        [Newtonsoft.Json.JsonProperty("patron", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Patron { get; set; }

        [Newtonsoft.Json.JsonProperty("playTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PlayTime PlayTime { get; set; }

        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Title Title { get; set; }
    }
}
