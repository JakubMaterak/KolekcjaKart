using KolekcjaKart.Data;
using KolekcjaKart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Logic
{
    public class CardManager : ICardManager
    {
        private readonly AppDbContext _db;
        public CardManager(AppDbContext db)
        {
            _db = db;
        }
        public ICardManager AddCard(Card card)
        {
            _db.Add(card);
            return this;
        }

        public Card GetCard(int id)
        {
            return _db.Cards.Find(id);
        }

        public List<Card> GetCards()
        {
            return _db.Cards.ToList();
        }

        public ICardManager RemoveCard(int id)
        {
            Card card = new Card() { CardId = id };
            _db.Cards.Attach(card);
            _db.Cards.Remove(card);
            return this;
        }
    }
}
