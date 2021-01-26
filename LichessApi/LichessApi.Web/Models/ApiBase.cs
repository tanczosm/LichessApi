using LichessApi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Models
{
    public class ApiBase : ICanInitialize
    {
        public LichessApiClient LiClient { get; private set; }

        public void Initialize(LichessApiClient liClient)
        {
            this.LiClient = liClient;
        }
    }
}
