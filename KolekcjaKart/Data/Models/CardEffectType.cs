using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Data.Models
{
    public enum CardEffectType : byte
    {
        [Display(Name = "No Effect")]
        NO_EFFECT,
        [Display(Name = "On Reveal")]
        ON_REVEAL,
        [Display(Name = "Ongoing")]
        ONGOING,
        [Display(Name = "Different")]
        DIFFERENT
    }
}
