﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api
{
    interface ICanInitialize
    {
        void Initialize(IApiConnector api);
    }
}
