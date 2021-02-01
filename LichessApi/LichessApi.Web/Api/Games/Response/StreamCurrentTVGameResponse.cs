using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;

namespace LichessApi.Web.Api.Games.Response
{
    public class StreamCurrentTVGameResponse
    {
        [Newtonsoft.Json.JsonProperty("t", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StreamTVGameDescription GameDescription { get; set; }
    }
}
