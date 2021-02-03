using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Relations
{
    public class Relations : ApiBase, IRelations
    {
        /// <summary>
        /// Get users followed by a user
        /// Access relations between users.
        /// <see href="https://lichess.org/api#tag/Relations"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<UserExtended> GetUsersFollowed(string username, [EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.GetUsersFollowed(username), HttpMethod.Get, token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<UserExtended>(response, token))
            {
                yield return o;
            }
        }

        /// <summary>
        /// Get users who follow a user
        /// <see href="https://lichess.org/api#operation/apiUserFollowers"/></see>
        /// </summary>
        /// <returns></returns>
        public async IAsyncEnumerable<UserExtended> GetUsersWhoFollowUser(string username, [EnumeratorCancellation] CancellationToken token = default)
        {
            var response = await API.SendRawRequest(LichessApiConstants.EndPoints.GetUsersWhoFollowUser(username), HttpMethod.Get, token: token).ConfigureAwait(false);

            await foreach (var o in StreamNdJson<UserExtended>(response, token))
            {
                yield return o;
            }
        }
    }
}
