using LichessApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using LichessApi.Api.Account.Response;
using LichessApi.Web.Api.Account.Request;
using LichessApi.Web.Entities;

namespace LichessApi.Api.Account
{
    public class Account : ApiBase
    {
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// Retrieves member email address
        /// Required Scope: LichessApiConstants.Scopes.EmailRead
        /// </summary>
        /// <returns></returns>
        public Task<EmailResponse> GetEmailAddress()
        {
            return API.Get<EmailResponse>(LichessApiConstants.EndPoints.GetMyEmailAddress());
        }

        /// <summary>
        /// Required Scope: LichessApiConstants.Scopes.PreferencesRead
        /// </summary>
        /// <returns></returns>
        public Task<UserPreferences> GetPreferences()
        {
            return API.Get<UserPreferences>(LichessApiConstants.EndPoints.GetMyPreferences());
        }

        /// <summary>
        /// Required Scope: LichessApiConstants.Scopes.PreferencesRead
        /// </summary>
        /// <returns></returns>
        public Task<GetMyKidModeResponse> GetKidModeStatus()
        {
            return API.Get<GetMyKidModeResponse>(LichessApiConstants.EndPoints.GetMyKidModeStatus());
        }

        /// <summary>
        /// Required Scope: LichessApiConstants.Scopes.PreferencesWrite
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public Task<OkResponse> SetMyKidModeStatus(bool v)
        {
            var request = new SetMyKidModeStatusRequest
            {
                V = v
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.SetMyKidModeStatus(), request.BuildQueryParams());
        }
    }
}
