using AutoMapper;
using KolekcjaKart.Data.Models;
using KolekcjaKart.Logic;
using KolekcjaKart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolekcjaKart.Controllers
{
    public class CardController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICardManager _cardManager;
        public CardController(IMapper mapper, ICardManager cardManager)
        {
            _mapper = mapper;
            _cardManager = cardManager;
        }


        // GET: CardController
        public ActionResult Index()
        {
            var cards = _cardManager.GetCards();
            return View(_mapper.Map<List<Card>, List<CardViewModel>>(cards));
        }

        // GET: CardController/Details/5
        public ActionResult Details(int id)
        {
            var card = _cardManager.GetCard(id);
            return View(_mapper.Map<Card, CardViewModel>(card));
        }

        // GET: CardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CardViewModel cardVm)
        {
            try
            {
                var card = _mapper.Map<CardViewModel, Card>(cardVm);
                _cardManager.AddCard(card);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardController/Delete/5
        public ActionResult Delete(int id)
        {
            var card = _cardManager.GetCard(id);
            return View(_mapper.Map<CardViewModel>(card));
        }

        // POST: CardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _cardManager.RemoveCard(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
