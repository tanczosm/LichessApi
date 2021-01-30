using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum GameStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"unknownfinish")]
        Unknown = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"aborted")]
        Aborted = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"mate")]
        Mate = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"resign")]
        Resign = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"stalemate")]
        Stalemate = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"timeout")]
        Timeout = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"outoftime")]
        OutOfTime = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"nostart")]
        NoStart = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"cheat")]
        Cheat = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"variantend")]
        VariantEnd = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"created")]
        Created = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"draw")]
        Draw = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"started")]
        Started = 11,

    }
}
