using Microsoft.AspNetCore.Mvc;
using RentalSite.Models;

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
