using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Models
{
    public class Activity
    {
        [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Interval Interval { get; set; }

        [Newtonsoft.Json.JsonProperty("games", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GameActivity Games { get; set; }

        [Newtonsoft.Json.JsonProperty("puzzles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UserPuzzleActivity Puzzles { get; set; }

        [Newtonsoft.Json.JsonProperty("tournaments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Tournaments Tournaments { get; set; }

        [Newtonsoft.Json.JsonProperty("practice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<Practice> Practice { get; set; }

        [Newtonsoft.Json.JsonProperty("correspondenceMoves", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorrespondenceMoves CorrespondenceMoves { get; set; }

        [Newtonsoft.Json.JsonProperty("correspondenceEnds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorrespondenceEnds CorrespondenceEnds { get; set; }

        [Newtonsoft.Json.JsonProperty("follows", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Follows Follows { get; set; }

        [Newtonsoft.Json.JsonProperty("teams", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<LightTeam> Teams { get; set; }

        [Newtonsoft.Json.JsonProperty("posts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<Topic> Topics { get; set; }
    }
}
