using Lab_8_2.Models;
using Microsoft.AspNetCore.Mvc;
namespace Lab_8_2.Controllers
{
    public class IdeaController : Controller
    {
        public IActionResult About(int num) => View(num);

    }
}
