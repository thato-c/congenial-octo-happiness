using Microsoft.AspNetCore.Mvc;

namespace RentalSite.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
