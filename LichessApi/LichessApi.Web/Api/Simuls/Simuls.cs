using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Simuls
{
    public class Simuls : ApiBase, ISimuls
    {
        /// <summary>
        /// Get current simuls
        /// Get recently finished, ongoing, and upcoming simuls.
        /// <see href="https://lichess.org/api#operation/apiSimul"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<Simul> GetCurrentSimuls()
        {
            return API.Get<Simul>(LichessApiConstants.EndPoints.GetCurrentSimuls());
        }

    }
}
