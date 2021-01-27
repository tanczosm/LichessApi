using System;
using System.Threading.Tasks;

namespace LichessApi.Web.Http
{
  public interface IHTTPClient : IDisposable
  {
    Task<IResponse> DoRequest(IRequest request);
    void SetRequestTimeout(TimeSpan timeout);
  }
}
