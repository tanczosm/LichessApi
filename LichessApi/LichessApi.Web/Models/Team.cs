using LichessApi.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Models
{
    public class Team
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("open")]
        public bool Open { get; set; }

        [Newtonsoft.Json.JsonProperty("leader")]
        public LightUser Leader { get; set; }

        [Newtonsoft.Json.JsonProperty("leaders")]
        public List<LightUser> Leaders { get; set; }

        [Newtonsoft.Json.JsonProperty("nbMembers")]
        public int NumberOfMembers { get; set; }
    }
}
