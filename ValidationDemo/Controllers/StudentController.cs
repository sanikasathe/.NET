using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

public class StudentController : Controller
{
    // GET method
    public IActionResult Create()
    {
        return View();
    }

    // POST method
    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Message = "Form Submitted Successfully";
            return View(new Student());
        }

        return View(student);
    }
}