using LichessApi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Http;

namespace LichessApi.Models
{
    public class ApiBase : ICanInitialize
    {
        protected IApiConnector API { get; private set; }

        public void Initialize(IApiConnector api)
        {
            this.API = api;
        }
    }
}
