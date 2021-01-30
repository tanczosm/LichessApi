using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum PerfType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ultraBullet")]
        UltraBullet = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"bullet")]
        Bullet = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"blitz")]
        Blitz = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"rapid")]
        Rapid = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"classical")]
        Classical = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"correspondence")]
        Correspondence = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"chess960")]
        Chess960 = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"crazyhouse")]
        Crazyhouse = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"antichess")]
        Antichess = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"atomic")]
        Atomic = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"horde")]
        Horde = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"kingOfTheHill")]
        KingOfTheHill = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"racingKings")]
        RacingKings = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"threeCheck")]
        ThreeCheck = 13,

    }

}
