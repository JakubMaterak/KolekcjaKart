using KolekcjaKart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Models
{
    public class CardViewModel
    {
        public int CardId { get; set; }
        public CardEffectType CardEffectType { get; set; }
        public string Name { get; set; }
        public Pool Pool { get; set; }
        public string Text { get; set; } = "";
        public int Power { get; set; }
        public int Cost { get; set; }
    }
}
