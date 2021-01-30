using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Account.Response
{
    public class GetMyKidModeResponse
    {
        [Newtonsoft.Json.JsonProperty("kid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Kid { get; set; }
    }
}
