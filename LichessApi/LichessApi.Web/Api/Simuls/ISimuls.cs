using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Simuls
{
    public interface ISimuls
    {
        void Initialize(IApiConnector api);

        Task<Simul> GetCurrentSimuls();
    }
}