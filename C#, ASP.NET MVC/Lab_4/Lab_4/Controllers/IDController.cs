using Microsoft.AspNetCore.Mvc;

namespace Lab_4.Controllers
{
    public class IDController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            return View("About");
        }
    }
}
