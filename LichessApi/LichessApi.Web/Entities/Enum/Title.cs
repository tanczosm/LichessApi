using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum Title
    {
        [System.Runtime.Serialization.EnumMember(Value = @"")]
        NONE = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"GM")]
        GM = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"WGM")]
        WGM = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"IM")]
        IM = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"WIM")]
        WIM = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"FM")]
        FM = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"WFM")]
        WFM = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"NM")]
        NM = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"CM")]
        CM = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"WCM")]
        WCM = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"WNM")]
        WNM = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"LM")]
        LM = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"BOT")]
        BOT = 12,

    }
}
