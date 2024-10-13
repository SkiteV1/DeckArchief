using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class CollectionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
