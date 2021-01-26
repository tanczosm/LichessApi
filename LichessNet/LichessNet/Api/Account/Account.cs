using LichessNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using LichessNet.Api.Account.Response;
using LichessNet.Entities;

namespace LichessNet.Api.Account
{
    public class Account : ApiBase
    {
        public async Task<ApiResponse<UserExtended>> GetMyProfile()
        {
            ApiRequest request = new ApiRequest(LiClient, LichessNetConstants.EndPoints.GetMyProfileEndPointUrl, Method.GET);

            return await request.Execute<UserExtended>();
        }

        public async Task<ApiResponse<EmailResponse>> GetMyEmailAddress()
        {
            string[] claims = { LichessNetConstants.Scopes.EmailRead };

            ApiRequest request = new ApiRequest(LiClient, LichessNetConstants.EndPoints.GetMyEmailAddressEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<EmailResponse>();
        }

        public async Task<ApiResponse<UserPreferences>> GetMyPreferences()
        {
            string[] claims = { LichessNetConstants.Scopes.PreferencesRead };

            ApiRequest request = new ApiRequest(LiClient, LichessNetConstants.EndPoints.GetMyPreferencesEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<UserPreferences>();
        }

        public async Task<ApiResponse<GetMyKidModeResponse>> GetMyKidModeStatus()
        {
            string[] claims = { LichessNetConstants.Scopes.PreferencesRead };

            ApiRequest request = new ApiRequest(LiClient, LichessNetConstants.EndPoints.GetMyKidModeStatusEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<GetMyKidModeResponse>();
        }

        public async Task<ApiResponse<OkResponse>> SetMyKidModeStatus(bool v)
        {
            string[] claims = { LichessNetConstants.Scopes.PreferencesWrite };

            var payload = new
            {
                v
            };

            ApiRequest request = new ApiRequest(LiClient, LichessNetConstants.EndPoints.SetMyKidModeStatusEndPointUrl,
                Method.POST, payload: payload, requiredScopes: claims);

            return await request.Execute<OkResponse>();
        }
    }
}
