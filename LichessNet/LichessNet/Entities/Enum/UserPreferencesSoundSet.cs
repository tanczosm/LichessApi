using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessNet.Enum
{
    public enum UserPreferencesSoundSet
    {
        [System.Runtime.Serialization.EnumMember(Value = @"silent")]
        Silent = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"standard")]
        Standard = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"piano")]
        Piano = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"nes")]
        Nes = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"sfx")]
        Sfx = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"futuristic")]
        Futuristic = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"robot")]
        Robot = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"music")]
        Music = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"speech")]
        Speech = 8,

    }
}
