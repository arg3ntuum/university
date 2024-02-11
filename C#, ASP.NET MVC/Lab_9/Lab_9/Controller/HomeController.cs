using Lab_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab_9.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Immovables immovables = new Immovables { Id = id.Value };
                db.Entry(immovables).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet("IndexSort")]
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["TypeSortParm"] = sortOrder == "type" ? "type_desc" : "type";
            ViewData["ClassSortParm"] = sortOrder == "class" ? "class_desc" : "class";

            var immovables = from i in db.Immovables
                             select i;

            switch (sortOrder)
            {
                case "name_desc":
                    immovables = immovables.OrderByDescending(i => i.Name);
                    break;
                case "type":
                    immovables = immovables.OrderBy(i => i.Type);
                    break;
                case "type_desc":
                    immovables = immovables.OrderByDescending(i => i.Type);
                    break;
                case "class":
                    immovables = immovables.OrderBy(i => i.Class);
                    break;
                case "class_desc":
                    immovables = immovables.OrderByDescending(i => i.Class);
                    break;
                default:
                    immovables = immovables.OrderBy(i => i.Name);
                    break;
            }

            return View(await immovables.ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Immovables? immovables = await db.Immovables.FirstOrDefaultAsync(p => p.Id == id);
                if (immovables != null) 
                    return View(immovables);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Immovables immovables)
        {
            db.Immovables.Update(immovables);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await db.Immovables.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Immovables immovables)
        {
            db.Immovables.Add(immovables);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
