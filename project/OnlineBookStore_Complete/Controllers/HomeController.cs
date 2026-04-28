using Microsoft.AspNetCore.Mvc;

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
