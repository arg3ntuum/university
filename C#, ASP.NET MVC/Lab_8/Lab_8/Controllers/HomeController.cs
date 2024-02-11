using Microsoft.AspNetCore.Mvc;

namespace Lab_8.Controllers

{

    public class HomeController : Controller

    {

        public IActionResult Index() => View();

        public string Contacts() => "Contacts page";

    }

}