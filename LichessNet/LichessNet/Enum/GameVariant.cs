using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Enum
{
    public enum GameVariant
    {
        [System.Runtime.Serialization.EnumMember(Value = @"standard")]
        Standard = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"chess960")]
        Chess960 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"crazyhouse")]
        Crazyhouse = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"antichess")]
        Antichess = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"atomic")]
        Atomic = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"horde")]
        Horde = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"kingOfTheHill")]
        KingOfTheHill = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"racingKings")]
        RacingKings = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"threeCheck")]
        ThreeCheck = 8,

    }
}
