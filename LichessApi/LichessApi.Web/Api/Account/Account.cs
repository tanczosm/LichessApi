using LichessApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using LichessApi.Api.Account.Response;
using LichessApi.Entities;

namespace LichessApi.Api.Account
{
    public class Account : ApiBase
    {
        public async Task<ApiResponse<UserExtended>> GetMyProfile()
        {
            ApiRequest request = new ApiRequest(LiClient, LichessApiConstants.EndPoints.GetMyProfileEndPointUrl, Method.GET);

            return await request.Execute<UserExtended>();
        }

        public async Task<ApiResponse<EmailResponse>> GetMyEmailAddress()
        {
            string[] claims = { LichessApiConstants.Scopes.EmailRead };

            ApiRequest request = new ApiRequest(LiClient, LichessApiConstants.EndPoints.GetMyEmailAddressEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<EmailResponse>();
        }

        public async Task<ApiResponse<UserPreferences>> GetMyPreferences()
        {
            string[] claims = { LichessApiConstants.Scopes.PreferencesRead };

            ApiRequest request = new ApiRequest(LiClient, LichessApiConstants.EndPoints.GetMyPreferencesEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<UserPreferences>();
        }

        public async Task<ApiResponse<GetMyKidModeResponse>> GetMyKidModeStatus()
        {
            string[] claims = { LichessApiConstants.Scopes.PreferencesRead };

            ApiRequest request = new ApiRequest(LiClient, LichessApiConstants.EndPoints.GetMyKidModeStatusEndPointUrl,
                Method.GET, requiredScopes: claims);

            return await request.Execute<GetMyKidModeResponse>();
        }

        public async Task<ApiResponse<OkResponse>> SetMyKidModeStatus(bool v)
        {
            string[] claims = { LichessApiConstants.Scopes.PreferencesWrite };

            var payload = new
            {
                v
            };

            ApiRequest request = new ApiRequest(LiClient, LichessApiConstants.EndPoints.SetMyKidModeStatusEndPointUrl,
                Method.POST, payload: payload, requiredScopes: claims);

            return await request.Execute<OkResponse>();
        }
    }
}
