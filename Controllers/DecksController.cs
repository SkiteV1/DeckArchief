using DeckArchief.Data;
using DeckArchief.Models;
using DeckArchief.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DeckArchief.Controllers
{
	public class DecksController : Controller
	{
		private readonly DeckDbContext _context;
		public DecksController(DeckDbContext context)
		{
			this._context = context;
		}

		/// <summary>
		/// Read from database.
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		/// Create new deck.
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		/// Update deck information.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult Edit(int id)
		{
			var deck = _context.Decks.SingleOrDefault(a => a.Id == id);

			try
			{
				if (deck != null)
				{
					var deckView = new ViewDecks()
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
					return View(deckView);
				}
				else
				{
					TempData["errorMessage"] = $"Deck details not available with the id:  {id}";
					return RedirectToAction("Index");
				}
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View();
			}
		}

		[HttpPost]
		public IActionResult Edit(ViewDecks deckModel)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var deck = new Deck()
					{
						Id = deckModel.Id,
						Name = deckModel.Name,
						Series = deckModel.Series,
						Price = deckModel.Price,
						BrandName = deckModel.BrandName,
						ProducerName = deckModel.ProducerName,
						Designer = deckModel.Designer,
						Color = deckModel.Color,
						CurrentValue1 = deckModel.CurrentValue1,
					};
					_context.Decks.Update(deck);
					_context.SaveChanges();
					TempData["succesMessage"] = "Deck is updated succesfully.";
					return RedirectToAction("Index");
				}
				else
				{
					TempData["errorMessage"] = $"Data is invalid.";
					return View();
				}
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View();
			}
		}

		/// <summary>
		/// Delete deck.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var deck = _context.Decks.SingleOrDefault(a => a.Id == id);

			try
			{
				if (deck != null)
				{
					var deckView = new ViewDecks()
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
					return View(deckView);
				}
				else
				{
					TempData["errorMessage"] = $"Deck details not available with the id:  {id}";
					return RedirectToAction("Index");
				}
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View();
			}
		}

		[HttpPost]
		public IActionResult Delete(ViewDecks deckModel)
		{
			var deck = _context.Decks.SingleOrDefault(a => a.Id == deckModel.Id);

			try
			{
				if (deck != null)
				{
					_context.Decks.Remove(deck);
					_context.SaveChanges();
					TempData["succesMessage"] = "Deck deleted succesfully.";
					return RedirectToAction("Index");
				}
				else
				{
					TempData["errorMessage"] = $"Deck details not available.";
					return RedirectToAction("Index");
				}
			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return View();
			}
		}
	}
}
