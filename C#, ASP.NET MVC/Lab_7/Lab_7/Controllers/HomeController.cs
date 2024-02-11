using Microsoft.AspNetCore.Mvc;

namespace Lab_7.Controllers

{

    public class HomeController : Controller

    {

        public IActionResult Index() => View();

        public IActionResult About() => View();

    }

}