using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum Title
    {
        [System.Runtime.Serialization.EnumMember(Value = @"GM")]
        GM = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"WGM")]
        WGM = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"IM")]
        IM = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"WIM")]
        WIM = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"FM")]
        FM = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"WFM")]
        WFM = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"NM")]
        NM = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"CM")]
        CM = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"WCM")]
        WCM = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"WNM")]
        WNM = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"LM")]
        LM = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"BOT")]
        BOT = 11,

    }
}
