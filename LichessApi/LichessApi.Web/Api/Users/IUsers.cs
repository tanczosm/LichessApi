using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Users.Response;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Entities.Enum;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Users
{
    public interface IUsers
    {
        void Initialize(IApiConnector api);
        Task<List<LightUser>> GetRealTimeUsersStatus(List<string> userIds);
        Task<GetTop10Response> GetTop10();
        Task<List<User>> GetOneLeaderboard(int numberOfUsers, PerfType gameVariant);
        Task<UserExtended> GetPublicProfile(string username);
        Task<List<RatingHistory>> GetRatingHistory(string username);
        Task<Activity> GetUserActivity(string username);
        Task<List<User>> GetUsersById(List<string> userIds);
        IAsyncEnumerable<UserExtended> GetTeamMembers(string teamId, CancellationToken token = default);
        Task<List<LightUser>> GetLiveStreamers();
        Task<CrossTable> GetCrosstable(string user1, string user2, bool matchup = false);
    }
}