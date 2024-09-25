using Microsoft.AspNetCore.Mvc;
using RentalSite.Models;
using System.Diagnostics;

namespace RentalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Sample Data
        private List<Property> _properties = new List<Property>
        {
            new Property {
                PropertyId = 1,
                Bedrooms = 1,
                Bathrooms = 1,
                ParkingSpaces = 1,
                ERFSize = 1500,
                About = "This is the first property",
                Province = "Gauteng",
                City = "Johannesburg",
                Suburb = "Bassonia"
            },

            new Property {
                PropertyId = 2,
                Bedrooms = 2,
                Bathrooms = 2,
                ParkingSpaces = 2,
                ERFSize = 1300,
                About = "This is the second property",
                Province = "Gauteng",
                City = "Johannesburg",
                Suburb = "Soweto"
            },

            new Property {
                PropertyId = 3,
                Bedrooms = 3,
                Bathrooms = 3,
                ParkingSpaces = 3,
                ERFSize = 1200,
                About = "This is the third property",
                Province = "Gauteng",
                City = "Johannesburg",
                Suburb = "Heaven"
            },

        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (_properties.Count == 0)
            {
                ViewBag.Message = "Properties not found.";
                return View();
            }
            return View(_properties);
        }

        public IActionResult Detail(int PropertyId)
        {
            var property = _properties.FirstOrDefault(p => p.PropertyId == PropertyId);

            if (property == null)
            {
                return NotFound();
            }

            return View(property);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
