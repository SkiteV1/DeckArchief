using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class WishlistsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
