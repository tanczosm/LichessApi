using System;
using System.Reflection;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class StringAttribute : Attribute
    {
        public StringAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }

#if NETSTANDARD2_0
    public static bool GetValue(Type enumType, Enum enumValue, out string? result)
#else
        public static bool GetValue(Type enumType, Enum enumValue, [NotNullWhen(true)] out string? result)
#endif
        {
            Ensure.ArgumentNotNull(enumType, nameof(enumType));
            Ensure.ArgumentNotNull(enumValue, nameof(enumValue));

            if (enumType
              .GetMember(enumValue.ToString())[0]
              .GetCustomAttributes(typeof(StringAttribute))
              .FirstOrDefault() is StringAttribute stringAttr)
            {
                result = stringAttr.Value;
                return true;
            }
            result = null;
            return false;
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
