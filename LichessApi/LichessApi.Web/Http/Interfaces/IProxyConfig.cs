#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web
{
  public interface IProxyConfig
  {
    string Host { get; }
    int Port { get; }
    string? User { get; }
    string? Password { get; }
    bool SkipSSLCheck { get; }
    /// <summary>
    ///   Whether to bypass the proxy server for local addresses.
    /// </summary>
    bool BypassProxyOnLocal { get; }
  }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
