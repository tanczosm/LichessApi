using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum EventType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"gameStart")]
        GameStart = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"gameFinish")]
        GameFinish = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"challenge")]
        Challenge = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"challengeCanceled")]
        ChallengeCanceled = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"challengeDeclined")]
        ChallengeDeclined = 4
    }
}
