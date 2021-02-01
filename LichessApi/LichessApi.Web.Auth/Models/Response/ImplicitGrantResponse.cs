using System;

namespace LichessApi.Web.Auth
{
    public class ImplictGrantResponse
    {
        public ImplictGrantResponse(string accessToken, string tokenType, int expiresIn)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
        }

        public string AccessToken { get; set; } = default!;
        public string TokenType { get; set; } = default!;
        public int ExpiresIn { get; set; }
        public string? State { get; set; } = default!;

        /// <summary>
        ///   Auto-Initalized to UTC Now
        /// </summary>
        /// <value></value>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsExpired { get => CreatedAt.AddSeconds(ExpiresIn) <= DateTime.UtcNow; }
    }
}
