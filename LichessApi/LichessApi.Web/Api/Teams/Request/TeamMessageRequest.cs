using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Teams.Request
{
    public class TeamMessageRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("message")]
        public string Message { get; set; }
    }
}
