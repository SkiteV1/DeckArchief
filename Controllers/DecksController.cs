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
	}
}
