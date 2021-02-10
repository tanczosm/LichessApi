using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Models
{
    public class UserPuzzleActivity
    {
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Score Score { get; set; }
    }
}
