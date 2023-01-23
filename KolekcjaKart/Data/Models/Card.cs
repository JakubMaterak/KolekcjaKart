using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Data.Models
{
    public class Card
    {
        [Required]
        public int CardId { get; set; }
        [Required]
        public CardEffectType CardType { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public Pool Pool { get; set; }
        [Required]
        [MaxLength(120)]
        public string Text { get; set; }
    }
}
