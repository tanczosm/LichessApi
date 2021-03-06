#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web
{
    public class ProxyConfig : IProxyConfig
    {
        public ProxyConfig(string host, int port)
        {
            Ensure.ArgumentNotNullOrEmptyString(host, nameof(host));

            Host = host;
            Port = port;
        }

        public string Host { get; }
        public int Port { get; }
        public string? User { get; set; }
        public string? Password { get; set; }
        public bool BypassProxyOnLocal { get; set; }
        public bool SkipSSLCheck { get; set; }
    }
}
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
