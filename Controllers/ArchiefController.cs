using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class ArchiefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
