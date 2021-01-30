using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using LichessApi.Web.Api.Account.Response;
using LichessApi.Web.Api.Account.Request;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Account
{
    public class Account : ApiBase, IAccount
    {
        /// <summary>
        /// Public informations about the logged in user.
        /// <see href="https://lichess.org/api#tag/Account"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetProfile()
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetMyProfile());
        }

        /// <summary>
        /// Get my email address
        /// Read the email address of the logged in user.
        /// Required Scope: LichessApiConstants.Scopes.EmailRead
        /// <see href="https://lichess.org/api#operation/accountEmail"/>
        /// </summary>
        /// <returns></returns>
        public Task<EmailResponse> GetEmailAddress()
        {
            return API.Get<EmailResponse>(LichessApiConstants.EndPoints.GetMyEmailAddress());
        }

        /// <summary>
        /// Get my preferences
        /// Read the preferences of the logged in user.
        /// Required Scope: LichessApiConstants.Scopes.PreferencesRead
        /// <see href="https://lichess.org/api#operation/account"/>
        /// </summary>
        /// <returns></returns>
        public Task<UserPreferences> GetPreferences()
        {
            return API.Get<UserPreferences>(LichessApiConstants.EndPoints.GetMyPreferences());
        }

        /// <summary>
        /// Get my kid mode status
        /// Read the kid mode status of the logged in user.
        /// Required Scope: LichessApiConstants.Scopes.PreferencesRead
        /// <see href="https://lichess.org/api#operation/accountKid"/>
        /// </summary>
        /// <returns></returns>
        public Task<GetMyKidModeResponse> GetKidModeStatus()
        {
            return API.Get<GetMyKidModeResponse>(LichessApiConstants.EndPoints.GetMyKidModeStatus());
        }

        /// <summary>
        /// Set my kid mode status
        /// Set the kid mode status of the logged in user.
        /// Required Scope: LichessApiConstants.Scopes.PreferencesWrite
        /// <see href="https://lichess.org/api#operation/accountKidPost"/>
        /// </summary>
        /// <param name="v"></param>
        /// <returns>OkResponse</returns>
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
