using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Data.Models
{
    public enum CardEffectType : byte
    {
        NO_EFFECT,
        ON_REVEAL,
        ONGOING,
        DIFFERENT
    }
}
