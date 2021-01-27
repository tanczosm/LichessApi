using System.Threading.Tasks;

namespace LichessApi.Web.Http
{
  public interface IJSONSerializer
  {
    void SerializeRequest(IRequest request);
    IApiResponse<T> DeserializeResponse<T>(IResponse response);
  }
}
