using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Account.Request
{
    public class SetMyKidModeStatusRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("v", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool V { get; set; }
    }
}
