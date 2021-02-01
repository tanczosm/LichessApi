using LichessApi.Web.Entities;
using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Users.Response;
using LichessApi.Web.Entities.Enum;
using Newtonsoft.Json;
using Shouldly;

namespace LichessApi.Web.Api.Users
{
    public class Users : ApiBase
    {
        /// <summary>
        /// Read the online, playing and streaming flags of several users.
        /// This API is very fast and cheap on lichess side.So you can call it quite often(like once every 5 seconds).
        /// Use it to track players and know when they're connected on lichess and playing games.
        /// <see href="https://lichess.org/api#operation/apiUsersStatus"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<LightUser>> GetRealTimeUsersStatus(List<string> userIds)
        {
            userIds.ShouldNotBeEmpty();

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["ids"] = String.Join(",", userIds);

            return API.Post<List<LightUser>>(LichessApiConstants.EndPoints.GetRealtimeUsersStatus(), request);
        }

        /// <summary>
        /// Get the top 10 players for each speed and variant.
        /// See https://lichess.org/player.
        /// <see href="https://lichess.org/api#operation/player"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<GetTop10Response> GetTop10()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers["Accept"] = "application/vnd.lichess.v3+json";

            return API.Get<GetTop10Response>(LichessApiConstants.EndPoints.GetAllTopTen(), null, headers);
        }

        /// <summary>
        /// Get the leaderboard for a single speed or variant (a.k.a. perfType). There is no leaderboard for correspondence or puzzles.
        /// <see href="https://lichess.org/api#operation/playerTopNbPerfType"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<User>> GetOneLeaderboard(int numberOfUsers, PerfType gameVariant)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers["Accept"] = "application/vnd.lichess.v3+json";

            string perfType = JsonConvert.SerializeObject(gameVariant,
                new Newtonsoft.Json.Converters.StringEnumConverter()).Replace("\"", "");

            return API.Get<List<User>>(LichessApiConstants.EndPoints.GetOneLeaderboard(numberOfUsers.ToString(), perfType), null, headers);
        }

        /// <summary>
        /// Get user public data
        /// Read public data of a user.
        /// <see href="https://lichess.org/api#operation/apiUser"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<UserExtended> GetPublicProfile(string username)
        {
            return API.Get<UserExtended>(LichessApiConstants.EndPoints.GetPublicUserData(username));
        }


        /// <summary>
        /// Read rating history of a user, for all perf types. There is at most one entry per day. Format of an entry is [year, month, day, rating].
        /// month starts at zero (January).
        /// <see href="https://lichess.org/api#operation/apiUserRatingHistory"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<RatingHistory>> GetRatingHistory(string username)
        {
            return API.Get<List<RatingHistory>>(LichessApiConstants.EndPoints.GetUserRatingHistory(username));
        }

        /// <summary>
        /// Get user activity
        /// Read data to generate the activity feed of a user.
        /// <see href="https://lichess.org/api#operation/apiUserActivity"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<Activity> GetUserActivity(string username)
        {
            return API.Get<Activity>(LichessApiConstants.EndPoints.GetUserActivity(username));
        }

        /// <summary>
        /// Get up to 300 users by their IDs. Users are returned in the order same order as the IDs.
        /// The method is POST so a longer list of IDs can be sent in the request body.
        /// <see href="https://lichess.org/api#operation/apiUsers"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<User>> GetUsersById(List<string> userIds)
        {
            userIds.ShouldNotBeEmpty();
            userIds.Count.ShouldBeLessThanOrEqualTo(300);

            Dictionary<string, string> request = new Dictionary<string, string>();
            request["ids"] = String.Join(",", userIds);

            return API.Post<List<User>>(LichessApiConstants.EndPoints.GetUsersById(), null, request);
        }

        /// <summary>
        /// Get members of a team
        /// Members are sorted by reverse chronological order of joining the team (most recent first).
        /// <see href="https://lichess.org/api#operation/teamIdUsers"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<UserExtended> GetTeamMembers(string teamId, [EnumeratorCancellation] CancellationToken token = default)
        {
            teamId.ShouldNotBeNullOrEmpty();

            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.GetTeamMembers(teamId), HttpMethod.Get, token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<UserExtended>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Get live streamers
        /// Get basic info about currently streaming users.
        ///
        /// This API is very fast and cheap on lichess side.So you can call it quite often(like once every 5 seconds).
        /// <see href="https://lichess.org/api#operation/streamerLive"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<List<LightUser>> GetLiveStreamers()
        {
            return API.Get<List<LightUser>>(LichessApiConstants.EndPoints.GetLiveStreamers());
        }

        /// <summary>
        /// Get total number of games, and current score, of any two users.
        /// If the matchup flag is provided, and the users are currently playing,
        /// also gets the current match game number and scores.
        /// <see href=""/></see>
        /// </summary>
        /// <returns></returns>
        public Task<CrossTable> GetCrosstable(string user1, string user2, bool matchup = false)
        {
            Dictionary<string,string> _params = new Dictionary<string, string>();

            if (matchup)
                _params.Add("matchup", matchup.ToString().ToLower());

            return API.Get<CrossTable>(LichessApiConstants.EndPoints.GetCrosstable(user1, user2), _params);
        }
    }
}
