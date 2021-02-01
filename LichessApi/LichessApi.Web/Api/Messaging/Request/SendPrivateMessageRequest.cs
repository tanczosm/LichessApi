using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Messaging.Request
{
    public class SendPrivateMessageRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }
    }
}
