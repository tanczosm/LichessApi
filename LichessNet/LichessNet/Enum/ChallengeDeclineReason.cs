using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Enum
{
    public enum ChallengeDeclineReason
    {
        [System.Runtime.Serialization.EnumMember(Value = @"generic")]
        Generic = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"later")]
        Later = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"tooFast")]
        TooFast = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"tooSlow")]
        TooSlow = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"timeControl")]
        TimeControl = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"rated")]
        Rated = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"casual")]
        Casual = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"standard")]
        Standard = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"variant")]
        Variant = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"noBot")]
        NoBot = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"onlyBot")]
        OnlyBot = 10,

    }
}
