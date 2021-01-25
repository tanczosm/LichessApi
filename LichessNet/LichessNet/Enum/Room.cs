using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Enum
{
    public enum Room
    {
        [System.Runtime.Serialization.EnumMember(Value = @"player")]
        Player = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"spectator")]
        Spectator = 1,

    }
}
