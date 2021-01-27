namespace LichessApi.Web.Http
{
  public interface IApiResponse<out T>
  {
    T? Body { get; }

    IResponse Response { get; }
  }
}
