using LichessNet.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Models
{
    public class ApiBase : ICanInitialize
    {
        public LichessNetClient LiClient { get; private set; }

        public void Initialize(LichessNetClient liClient)
        {
            this.LiClient = liClient;
        }
    }
}
