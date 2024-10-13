using DeckArchief.Data;
using DeckArchief.Models;
using DeckArchief.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
	public class DecksController : Controller
	{
		private readonly DeckDbContext _context;
		public DecksController(DeckDbContext context)
		{
			this._context = context;
		}

		public IActionResult Index()
		{
			var decks = _context.Decks.ToList();
			List<ViewDecks> deckList = new List<ViewDecks>();

			if (decks != null)
			{

				foreach (var deck in decks)
				{
					var ViewDeck = new ViewDecks()
					{
						Id = deck.Id,
						Name = deck.Name,
						Series = deck.Series,
						Price = deck.Price,
						BrandName = deck.BrandName,
						ProducerName = deck.ProducerName,
						Designer = deck.Designer,
						Color = deck.Color,
						CurrentValue1 = deck.CurrentValue1,
					};
					deckList.Add(ViewDeck);
				}
				return View(deckList);
			}
			return View(deckList);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(ViewDecks deckData)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var deck = new Deck()
					{
						Name = deckData.Name,
						Series = deckData.Series,
						Price = deckData.Price,
						BrandName = deckData.BrandName,
						ProducerName = deckData.ProducerName,
						Designer = deckData.Designer,
						Color = deckData.Color,
						CurrentValue1 = deckData.CurrentValue1,
					};

					_context.Decks.Add(deck);
					_context.SaveChanges();
					TempData["succesMessage"] = "Deck is added to your collection.";
					return RedirectToAction("Index");
				}
				else
				{
					TempData["errorMessage"] = "Something went wrong, try again!";
				}
				return View();
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View();
			}
		}

	}
}
