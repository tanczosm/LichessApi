using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Teams.Request
{
    public class JoinTeamRequest : RequestParams
    {
        [Newtonsoft.Json.JsonProperty("message")]
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("password")]
        public string Password { get; set; }
    }
}
