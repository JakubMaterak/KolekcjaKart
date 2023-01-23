using KolekcjaKart.Data;
using KolekcjaKart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Logic
{
    public interface ICardManager
    {
        ICardManager AddCard(Card card);
        ICardManager RemoveCard(int id);
        List<Card> GetCards();
        Card GetCard(int id);
        ICardManager ModifyCard(Card card);
    }
}
