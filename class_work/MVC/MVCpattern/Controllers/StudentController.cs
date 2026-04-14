using Microsoft.AspNetCore.Mvc;
using MVCpattern.Models;
using System.Collections.Generic;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        List<Student> student = new List<Student>
        {
            new Student { Id=1, Name="sanika",course="python"},
            new Student { Id=2, Name="pranali",course="dotnet"},
            new Student { Id=3, Name="prachi",course="genai"}
        };

        return View(student);
    }
}