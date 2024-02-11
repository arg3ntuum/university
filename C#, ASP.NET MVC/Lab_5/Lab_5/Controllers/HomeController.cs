using Microsoft.AspNetCore.Mvc;
using Lab_5.Models; // простір імен моделі Person

namespace Lab_5.Controllers
{
    public class HomeController : Controller
    {
        List<Student> people = new List<Student>

{
new Student(1, "Demid", 20, "KI-21-2"),
new Student(2, "Rostyslav", 19,  "KI-21-2"),
new Student(3, "Stanislav", 20, "KI-21-2"),
new Student(4, "Konstantin", 20, "KI-21-2"),
};

        public IActionResult Index()

        {

            return View(people);

        }

    }

}