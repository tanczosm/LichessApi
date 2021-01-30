using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Challenges.Response;

namespace LichessApi.Web.Services
{
    /// <summary>
    /// I have no idea what I want to do with this just yet
    /// </summary>
    public class UserEventMonitorService : BackgroundService
    {
        private List<ILichessApiClient> clients;

        public UserEventMonitorService()
        {
            clients = new List<ILichessApiClient>();
        }

        protected override async Task ExecuteAsync(CancellationToken stopToken)
        {

            while (!stopToken.IsCancellationRequested)
            {
                foreach (var client in clients)
                {
                    // Attempt to establish connection with server to stream events
                    await foreach (EventStreamResponse evt in client.Challenges.StreamIncomingEvents(stopToken))
                    {
                        if (stopToken.IsCancellationRequested)
                            break;

                    }
                }
            }

        }
    }
}
