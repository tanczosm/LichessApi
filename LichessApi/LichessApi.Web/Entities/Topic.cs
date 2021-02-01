using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities
{
    public class Topic
    {
        [Newtonsoft.Json.JsonProperty("topicUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("topicName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("posts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public List<Post> Posts { get; set; }
    }
}
