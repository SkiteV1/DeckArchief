using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
