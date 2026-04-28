using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "C# Programming", Author = "John Smith", Price = 450 },
            new Book { Id = 2, Title = "ASP.NET Core MVC", Author = "David Wilson", Price = 650 },
            new Book { Id = 3, Title = "Database Management", Author = "Robert King", Price = 500 }
        };

        private bool IsLoggedIn()
        {
            return HttpContext.Session.GetString("User") != null;
        }

        private bool IsAdmin()
        {
            return HttpContext.Session.GetString("Role") == "Admin";
        }

        public IActionResult Index(bool success = false)
        {
            if (!IsLoggedIn())
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.User = HttpContext.Session.GetString("User");
            ViewBag.Role = HttpContext.Session.GetString("Role");
            ViewBag.Success = success;  // 👈 added

            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (!IsLoggedIn() || !IsAdmin())
                return RedirectToAction("Index");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!IsLoggedIn() || !IsAdmin())
                return RedirectToAction("Index");

            book.Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
            books.Add(book);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!IsLoggedIn() || !IsAdmin())
                return RedirectToAction("Index");

            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            if (!IsLoggedIn() || !IsAdmin())
                return RedirectToAction("Index");

            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book == null) return NotFound();

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Price = updatedBook.Price;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (!IsLoggedIn() || !IsAdmin())
                return RedirectToAction("Index");

            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null) books.Remove(book);

            return RedirectToAction("Index");
        }
    }
}