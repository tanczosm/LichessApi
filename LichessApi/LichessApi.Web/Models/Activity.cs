using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    /// <summary>
    /// https://github.com/ornicar/lila/blob/master/modules/activity/src/main/Activity.scala
    /// </summary>
    public class Activity
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("games", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Games { get; set; }

        [Newtonsoft.Json.JsonProperty("posts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Posts { get; set; }

        [Newtonsoft.Json.JsonProperty("puzzles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Puzzles { get; set; }

        [Newtonsoft.Json.JsonProperty("storm", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Storm { get; set; }

        [Newtonsoft.Json.JsonProperty("learn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Learn { get; set; }

        [Newtonsoft.Json.JsonProperty("practice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Practice { get; set; }

        [Newtonsoft.Json.JsonProperty("simuls", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Simuls { get; set; }

        [Newtonsoft.Json.JsonProperty("corres", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Corres { get; set; }

        [Newtonsoft.Json.JsonProperty("patron", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Patron { get; set; }

        [Newtonsoft.Json.JsonProperty("follows", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Follows { get; set; }

        [Newtonsoft.Json.JsonProperty("studies", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Studies { get; set; }

        [Newtonsoft.Json.JsonProperty("teams", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Teams { get; set; }

        [Newtonsoft.Json.JsonProperty("stream", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Stream { get; set; }
    }
}
