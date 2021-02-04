using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Teams
{
    public interface ITeams
    {
        void Initialize(IApiConnector api);

        Task<List<SwissTournament>> GetTeamSwissTournaments(string teamId, int max = 100);
        Task<Team> GetSingleTeam(string teamId);
        Task<List<Team>> GetPopularTeams(string teamId, int page = 1);
        Task<List<Team>> GetTeamsOfPlayer(string username);
        Task<List<Team>> SearchTeams(string text, int page = 1);

        IAsyncEnumerable<ArenaTournament> GetTeamArenaTournaments(string teamId, int max,
            [EnumeratorCancellation] CancellationToken token = default);
        Task<OkResponse> JoinTeam(string teamId, string message, string password = null);
        Task<OkResponse> LeaveTeam(string teamId);
        Task<OkResponse> KickTeamMember(string teamId, string userId);
        Task<OkResponse> SendTeamMessage(string teamId, string message);
    }
}