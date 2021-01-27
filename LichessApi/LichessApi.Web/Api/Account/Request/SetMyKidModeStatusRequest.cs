using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Api.Account.Request
{
    public class SetMyKidModeStatusRequest : RequestParams
    {
        [QueryParam("v")]
        public bool V { get; set; }
    }
}
