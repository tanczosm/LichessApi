using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Teams.Request;
using LichessApi.Web.Entities;
using Shouldly;

namespace LichessApi.Web.Api.Teams
{
    public class Teams : ApiBase, ITeams
    {
        /// <summary>
        /// Get all swiss tournaments of a team.
        /// Tournaments are sorted by reverse chronological order of start date(last starting first).
        /// <see href="https://lichess.org/api#operation/apiUsersStatus"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<SwissTournament>> GetTeamSwissTournaments(string teamId, int max = 100)
        {
            teamId.ShouldNotBeNullOrEmpty();
            max.ShouldBeGreaterThan(0);

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["max"] = max.ToString();

            return API.Get<List<SwissTournament>>(LichessApiConstants.EndPoints.GetTeamSwissTournaments(teamId), request);
        }

        /// <summary>
        /// Get a single team
        /// Infos about a team
        /// <see href="https://lichess.org/api#operation/teamShow"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<Team> GetSingleTeam(string teamId)
        {
            return API.Get<Team>(LichessApiConstants.EndPoints.GetSingleTeam(teamId));
        }


        /// <summary>
        /// Get popular teams
        /// Paginator of the most popular teams.
        /// <see href="https://lichess.org/api#operation/teamAll"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<Team>> GetPopularTeams(string teamId, int page = 1)
        {
            teamId.ShouldNotBeNullOrEmpty();
            page.ShouldBeGreaterThan(0);

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["page"] = page.ToString();

            return API.Get<List<Team>>(LichessApiConstants.EndPoints.GetPopularTeams(), request);
        }


        /// <summary>
        /// Teams of a player
        /// All the teams a player is a member of.
        /// <see href="https://lichess.org/api#operation/teamOfUsername"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<Team>> GetTeamsOfPlayer(string username)
        {
            username.ShouldNotBeNullOrEmpty();

            return API.Get<List<Team>>(LichessApiConstants.EndPoints.TeamsOfPlayer(username));
        }

        /// <summary>
        /// Search teams
        /// Paginator of team search results for a keyword.
        /// <see href="https://lichess.org/api#operation/teamSearch"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<Team>> SearchTeams(string text, int page = 1)
        {
            text.ShouldNotBeNullOrEmpty();
            page.ShouldBeGreaterThan(0);

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["text"] = text;
            request["page"] = page.ToString();

            return API.Get<List<Team>>(LichessApiConstants.EndPoints.SearchTeams(), request);
        }

        /// <summary>
        /// Get team arena tournaments
        ///
        /// Get all arena tournaments relevant to a team.
        ///
        /// Tournaments are sorted by reverse chronological order of start date (last starting first).
        /// <see href="https://lichess.org/api#operation/apiTeamArena"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<ArenaTournament> GetTeamArenaTournaments(string teamId, int max, [EnumeratorCancellation] CancellationToken token = default)
        {
            teamId.ShouldNotBeEmpty();

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["max"] = max.ToString();

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.GetTeamArenaTournaments(teamId), HttpMethod.Get, parameters:request, headers: API.AcceptNdJsonHeaders(), token: token);

            await foreach (var o in StreamNdJson<ArenaTournament>(response, token))
            {
                yield return o;
            }
        }


        /// <summary>
        /// Join a team
        /// Join a team.If the team join policy requires a confirmation, and the team
        /// owner is not the oAuth app owner, and the message field is not set, then the call fails with 403 Forbidden.
        /// <see href="https://lichess.org/api#operation/teamIdJoin"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> JoinTeam(string teamId, string message, string password = null)
        {
            teamId.ShouldNotBeNullOrEmpty();
            message.ShouldNotBeNullOrEmpty();

            JoinTeamRequest request = new JoinTeamRequest
            {
                Message = message,
                Password = password
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.JoinTeam(teamId), null, body:request.BuildBodyParams());
        }

        /// <summary>
        /// Leave a team
        /// <see href="https://lichess.org/api#operation/teamIdQuit"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> LeaveTeam(string teamId)
        {
            teamId.ShouldNotBeNullOrEmpty();

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.LeaveTeam(teamId));
        }

        /// <summary>
        /// Kick a user from your team
        /// Kick a member out of one of your teams.
        /// <see href="https://lichess.org/api#operation/teamIdKickUserId"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> KickTeamMember(string teamId, string userId)
        {
            teamId.ShouldNotBeNullOrEmpty();
            userId.ShouldNotBeNullOrEmpty();

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.KickTeamUser(teamId, userId));
        }


        /// <summary>
        /// Message all members
        /// Send a private message to all members of a team.You must own the team.
        /// <see href="https://lichess.org/api#operation/teamIdPmAll"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> SendTeamMessage(string teamId, string message)
        {
            TeamMessageRequest request = new TeamMessageRequest
            {
                Message = message
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.MessageAllMembers(teamId), null, body: request.BuildBodyParams());
        }
    }
}
