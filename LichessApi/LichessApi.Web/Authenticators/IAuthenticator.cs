using System.Threading.Tasks;
using LichessApi.Web.Http;

namespace LichessApi.Web
{
    public interface IAuthenticator
    {
        Task Apply(IRequest request, IApiConnector apiConnector);
    }
}
