using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi
{
    public static class LichessApiDefaults
    {
        /// <summary>
        /// Base url for Api calls
        /// </summary>
        public static string EndPointBaseUrl { get; set; } = "https://lichess.org";

        /// <summary>
        /// Api request timeout in milliseconds
        /// </summary>
        public static int RequestTimeout { get; set; } = 5 * 1000;
    }
}
