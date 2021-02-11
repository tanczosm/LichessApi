using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LichessApi.Web.Entities.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GameVariant
    {
        [System.Runtime.Serialization.EnumMember(Value = @"standard")]
        Standard = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ultraBullet")]
        UltraBullet = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"bullet")]
        Bullet = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"blitz")]
        Blitz = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"rapid")]
        Rapid = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"classical")]
        Classical = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"correspondence")]
        Correspondence = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"chess960")]
        Chess960 = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"crazyhouse")]
        Crazyhouse = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"antichess")]
        Antichess = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"atomic")]
        Atomic = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"horde")]
        Horde = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"kingOfTheHill")]
        KingOfTheHill = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"racingKings")]
        RacingKings = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"threeCheck")]
        ThreeCheck = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"fromPosition")]
        FromPosition = 15
    }
}
