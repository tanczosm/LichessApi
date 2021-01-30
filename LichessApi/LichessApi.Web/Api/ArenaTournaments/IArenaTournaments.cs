using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;
using LichessApi.Web.Api.Account.Request;
using LichessApi.Web.Api.Account.Response;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.ArenaTournaments
{
    public interface IArenaTournaments
    {
        void Initialize(IApiConnector api);
    }
}