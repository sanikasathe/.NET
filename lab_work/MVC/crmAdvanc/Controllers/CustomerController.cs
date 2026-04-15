using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public IActionResult Create(Customer obj)
        {
            if (ModelState.IsValid)
            {
                return Content("Data Saved Successfully!");
            }
            return View(obj);
        }
    }
}