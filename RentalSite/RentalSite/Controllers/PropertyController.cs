using Microsoft.AspNetCore.Mvc;

namespace RentalSite.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
