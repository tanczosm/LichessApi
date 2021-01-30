using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Web.Entities.Enum
{
    public enum GameSpeed
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
    }
}
