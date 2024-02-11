using Microsoft.AspNetCore.Mvc;

namespace Lab_7_2.Controllers

{

    public class HomeController : Controller

    {
        [HttpGet]
        

        public IActionResult Index() => View();
        [HttpPost]
        public string Index(string Name, int Age, string Pass, bool isMarried, 
            string type, string language) => $"Анкета студента:\n" +
            $"Name: {Name};\n" +
            $"Age: {Age};\n" +
            $"Pass: {Pass};\n" +
            $"IsMarried: {isMarried};\n" +
            $"Type: {type};\n" +
            $"Language: {language};\n";

        public IActionResult About() => View();

    }

}