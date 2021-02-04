using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;

namespace LichessApi.Web.Models
{
    public class SwissTournament
    {
        [Newtonsoft.Json.JsonProperty("rated")]
        public bool Rated { get; set; }

        [Newtonsoft.Json.JsonProperty("clock")]
        public Clock Clock { get; set; }

        [Newtonsoft.Json.JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("greatPlayer")]
        public TournamentPlayer GreatPlayer { get; set; }

        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("nbOngoing")]
        public int NumberOfOngoing { get; set; }

        [Newtonsoft.Json.JsonProperty("nbPlayers")]
        public int NumberOfPlayers { get; set; }

        [Newtonsoft.Json.JsonProperty("nbRounds")]
        public int NumberOfRounds { get; set; }

        [Newtonsoft.Json.JsonProperty("nextRound")]
        public Round NextRound { get; set; }

        [Newtonsoft.Json.JsonProperty("quote")]
        public Quote Quote { get; set; }

        [Newtonsoft.Json.JsonProperty("round")]
        public int Round { get; set; }

        [Newtonsoft.Json.JsonProperty("startsAt")]
        public DateTime StartsAt { get; set; }

        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("variant")]
        public GameVariant Variant { get; set; } = GameVariant.Standard;
    }
}
