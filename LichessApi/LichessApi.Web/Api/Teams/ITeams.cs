using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Teams
{
    public interface ITeams
    {
        void Initialize(IApiConnector api);
    }
}