using DeckArchief.Data;
using DeckArchief.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeckArchief.Controllers
{
    public class BrandsController : Controller
    {
        private readonly DeckDbContext _context;

        public BrandsController(DeckDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var brands = _context.Brands.ToList();
			List<ViewBrands> brandList = new List<ViewBrands>();

			if (brands != null)
            {

                foreach (var brand in brands)
                {
                    var ViewBrand = new ViewBrands()
                    {
                        Id = brand.Id,
                        Name = brand.Name,
                        Adress = brand.Adress,
                        ProducerName = brand.ProducerName
                    };
                    brandList.Add(ViewBrand);
                }
				return View(brandList);
			}
            return View(brandList);
        }
    }
}
