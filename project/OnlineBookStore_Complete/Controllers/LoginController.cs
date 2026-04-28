using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class LoginController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Email = "admin@gmail.com", Password = "123456", Role = "Admin" }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            string email = model.Username.Trim().ToLower();
            string password = model.Password.Trim();

            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("User", user.Email);
                HttpContext.Session.SetString("Role", user.Role);

                // 👇 Added success flag
                return RedirectToAction("Index", "Book", new { success = true });
            }

            ViewBag.Error = "Invalid email or password";
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.Error = "All fields required";
                return View(user);
            }

            string email = user.Email.Trim().ToLower();

            if (users.Any(u => u.Email == email))
            {
                ViewBag.Error = "User already exists";
                return View(user);
            }

            user.Email = email;
            user.Role = "Student";

            users.Add(user);

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}