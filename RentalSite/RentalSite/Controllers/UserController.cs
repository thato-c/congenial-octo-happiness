using Microsoft.AspNetCore.Mvc;
using RentalSite.Models;
using RentalSite.ViewModels;

namespace RentalSite.Controllers
{
    public class UserController : Controller
    {
        // Sample data
        private List<User> _users = new List<User> 
        { 
            new User
            {
                UserId = 1,
                Username = "Thato",
                Password = "KillEmAll"
            },

            new User
            {
                UserId = 2,
                Username = "Albert",
                Password = "KillThemAll"
            },

            new User
            {
                UserId = 3,
                Username = "Thato",
                Password = "KillNone"
            },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid) 
            {
                var user = _users.FirstOrDefault(u => u.Username == viewModel.Username && u.Password == viewModel.Password);

                if (user != null)
                {
                    return View("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid username or password.";
                    return View("Index");
                }
            }
            return View("Index");
        }
    }
}
