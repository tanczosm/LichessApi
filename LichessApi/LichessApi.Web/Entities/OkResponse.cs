using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Api.Account.Response
{
    public class OkResponse
    {
        [Newtonsoft.Json.JsonProperty("ok", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Ok { get; set; }
    }
}
