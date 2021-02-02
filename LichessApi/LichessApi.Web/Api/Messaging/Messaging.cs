using LichessApi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Api.Messaging.Request;
using LichessApi.Web.Entities;

namespace LichessApi.Web.Api.Messaging
{
    public class Messaging : ApiBase, IMessaging
    {
        /// <summary>
        /// Send a private message
        /// Send a private message to another player.
        /// <see href="https://lichess.org/api#operation/inboxUsername"/></see>
        /// </summary>
        /// <returns></returns>
        public Task<OkResponse> SendPrivateMessage(string username, string message)
        {
            SendPrivateMessageRequest request = new SendPrivateMessageRequest
            {
                Text = message
            };

            return API.Post<OkResponse>(LichessApiConstants.EndPoints.SendPrivateMessage(username), null, body: request.BuildBodyParams());
        }
    }
}
