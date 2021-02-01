using System.Threading.Tasks;
using LichessApi.Web.Http;

namespace LichessApi.Web
{
    public class TokenAuthenticator : IAuthenticator
    {
        public TokenAuthenticator(string token, string tokenType)
        {
            Token = token;
            TokenType = tokenType;
        }

        public string Token { get; set; }

        public string TokenType { get; set; }

        public Task Apply(IRequest request, IApiConnector apiConnector)
        {
            request.Headers["Authorization"] = $"{TokenType} {Token}";
            return Task.CompletedTask;
        }
    }
}
