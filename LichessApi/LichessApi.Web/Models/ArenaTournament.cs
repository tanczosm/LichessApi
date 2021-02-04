using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public partial class ArenaTournament
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [Newtonsoft.Json.JsonProperty("clock", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Clock Clock { get; set; }

        [Newtonsoft.Json.JsonProperty("minutes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Minutes { get; set; }

        [Newtonsoft.Json.JsonProperty("createdBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("system", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ArenaTournamentSystem System { get; set; }

        [Newtonsoft.Json.JsonProperty("secondsToStart", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SecondsToStart { get; set; }

        [Newtonsoft.Json.JsonProperty("secondsToFinish", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SecondsToFinish { get; set; }

        [Newtonsoft.Json.JsonProperty("isFinished", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsFinished { get; set; }

        [Newtonsoft.Json.JsonProperty("isRecentlyFinished", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsRecentlyFinished { get; set; }

        [Newtonsoft.Json.JsonProperty("paringsClosed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool PairingsClosed { get; set; }

        [Newtonsoft.Json.JsonProperty("startsAt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime StartsAt { get; set; }

        [Newtonsoft.Json.JsonProperty("nbPlayers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfPlayers { get; set; }

        [Newtonsoft.Json.JsonProperty("perf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ArenaTournamentPerf Perf { get; set; }

        [Newtonsoft.Json.JsonProperty("schedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Schedule Schedule { get; set; }

        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Variant Variant { get; set; }

        [Newtonsoft.Json.JsonProperty("duels")]
        public List<Duel> Duels { get; set; }

        [Newtonsoft.Json.JsonProperty("standings")]
        public Standings Standings { get; set; }

        [Newtonsoft.Json.JsonProperty("featured")] 
        public FeaturedGame Featured { get; set; }

        [Newtonsoft.Json.JsonProperty("podium")]
        public List<Podium> Podium { get; set; }

        [Newtonsoft.Json.JsonProperty("stats")]
        public Stats Stats { get; set; }
        
    }
}
