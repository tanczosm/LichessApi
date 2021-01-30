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

namespace LichessApi.Web.Api.Account
{
    public interface IAccount
    {
        void Initialize(IApiConnector api);
        Task<UserExtended> GetProfile();
        Task<EmailResponse> GetEmailAddress();
        Task<UserPreferences> GetPreferences();
        Task<GetMyKidModeResponse> GetKidModeStatus();
        Task<OkResponse> SetMyKidModeStatus(bool v);
    }
}
