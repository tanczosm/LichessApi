using System;
using System.Threading.Tasks;
using LichessApi;
using LichessApi.Web;

namespace Example.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            LichessApiClient client = new LichessApiClient("abcdefghijklmnop");

            var email = await client.Account.GetEmailAddress();
            var isOk = await client.Account.SetMyKidModeStatus(false);
        }
    }
}
