using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustEat.HttpClientInterception;
using LichessApi.Web.Http;
using MartinCostello.Logging.XUnit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using Xunit.Abstractions;

namespace LichessApi.Web.Test
{
    public abstract class ApiTest : ITestOutputHelperAccessor
    {
        protected ApiTest()
        {
            Interceptor = new HttpClientInterceptorOptions()
                .ThrowsOnMissingRegistration()
                .RegisterBundle(Path.Combine(BundleName, "bundle.json"));

            LichessApiClientConfig config = LichessApiClientConfig.CreateDefault()
                .WithToken("abcdefgh")
                .WithHTTPClient(new NetHttpClient(Interceptor.CreateHttpClient()));

            ApiClient = new LichessApiClient(config);
        }

        public LichessApiClient ApiClient { get; set; }

        /// <summary>
        /// Gets or sets the xunit test output helper to route application logs to.
        /// </summary>
        public ITestOutputHelper? OutputHelper { get; set; }

        /// <summary>
        /// Gets the interceptor to use for configuring stubbed HTTP responses.
        /// </summary>
        public HttpClientInterceptorOptions Interceptor { get; }

        /// <summary>
        /// Gets the HTTP bundle name to use for the test.
        /// </summary>
        protected virtual string BundleName => GetType().Name.Replace("Tests", string.Empty, StringComparison.OrdinalIgnoreCase);

    }
}
