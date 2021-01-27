namespace LichessApi.Web.Http
{
  public class ApiResponse<T> : IApiResponse<T>
  {
    public ApiResponse(IResponse response, T? body = default)
    {
      Ensure.ArgumentNotNull(response, nameof(response));

      Body = body;
      Response = response;
    }

    public T? Body { get; set; }

    public IResponse Response { get; set; }
  }
}
