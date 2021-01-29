using System;
using System.Threading;
using System.Threading.Tasks;
using LichessApi;
using LichessApi.Web;
using LichessApi.Web.Api.Challenges.Response;

namespace Example.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            LichessApiClient client = new LichessApiClient("abcdefghijklmnop");

            var email = await client.Account.GetEmailAddress();
            var isOk = await client.Account.SetMyKidModeStatus(false);

            CancellationTokenSource cts = new CancellationTokenSource();

            await foreach (EventStreamResponse evt in client.Challenges.StreamIncomingEvents(cts.Token))
            {
            }

            System.Console.WriteLine("-- Finished --");
        }
    }
}
