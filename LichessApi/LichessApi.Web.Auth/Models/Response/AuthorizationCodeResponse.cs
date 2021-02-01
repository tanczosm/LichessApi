namespace LichessApi.Web.Auth
{
  public class AuthorizationCodeResponse
  {
    public AuthorizationCodeResponse(string code)
    {
      Code = code;
    }

    public string Code { get; set; } = default!;
    public string? State { get; set; } = default!;
  }
}
