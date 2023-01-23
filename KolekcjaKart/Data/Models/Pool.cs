using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Data.Models
{
    public enum Pool : byte
    {
        [Display(Name="Starter")]
        STARTER,
        [Display(Name="Pula 0")]
        POOL_0,
        [Display(Name = "Pula 1")]
        POOL_1,
        [Display(Name = "Pula 2")]
        POOL_2,
        [Display(Name = "Pula 3")]
        POOL_3,
        [Display(Name = "Pula 4")]
        POOL_4,
        [Display(Name = "Pula 5")]
        POOL_5,
        [Display(Name = "Przepustka sezonowa")]
        SEASON,
    }
}
