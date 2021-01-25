using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Api
{
    interface ICanInitialize
    {
        void Initialize(LichessNetClient liClient);
    }
}
