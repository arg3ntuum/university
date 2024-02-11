using Lab_8_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_8_2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index() => View(new Anketa());
        [HttpPost]
        public string Index(Anketa anketa) => $"Анкета студента:\n" +
            $"Name: {anketa.Name};\n" +
            $"Age: {anketa.Age};\n" +
            $"Pass: {anketa.Pass};\n" +
            $"IsMarried: {anketa.IsMarried};\n" +
            $"Type: {anketa.Type};\n" +
            $"Language: {anketa.Language};\n";
 
        public string Contacts() => "Contacts page";
    }

}