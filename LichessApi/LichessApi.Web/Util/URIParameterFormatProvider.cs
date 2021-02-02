using System.Web;
using System;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
namespace LichessApi.Web
{
    public class URIParameterFormatProvider : IFormatProvider
    {
        private readonly URIParameterFormatter _formatter;

        public URIParameterFormatProvider()
        {
            _formatter = new URIParameterFormatter();
        }

        public object? GetFormat(Type? formatType)
        {
            return formatType == typeof(ICustomFormatter) ? _formatter : null;
        }

        private class URIParameterFormatter : ICustomFormatter
        {
            public string Format(string? format, object? arg, IFormatProvider? formatProvider)
            {
                return HttpUtility.UrlEncode(arg?.ToString()) ?? string.Empty;
            }
        }
    }
}
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
