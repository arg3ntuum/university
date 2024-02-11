using Microsoft.AspNetCore.Mvc;
namespace Lab_3.Controllers
{
    public class HomeController : Controller

    {

        public IActionResult Index()

        {
            var people = new List<string> { "Taras", "Mykola", "Bogdan", "Rostyslav" };
            return View(people);

        }

    }
}
