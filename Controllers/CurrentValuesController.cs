using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class CurrentValuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
