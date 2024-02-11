using Lab_6_2.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;


namespace Lab_6_2.Controllers

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

                Student student = new Student { Id = id.Value };

                db.Entry(student).State = EntityState.Deleted;

                await db.SaveChangesAsync();

                return RedirectToAction("Index");

            }

            return NotFound();

        }
        public async Task<IActionResult> Edit(int? id)

        {

            if (id != null)

            {

                Student? student = await db.Students.FirstOrDefaultAsync(p => p.Id == id);

                if (student != null) return View(student);

            }

            return NotFound();

        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student student)

        {

            db.Students.Update(student);

            await db.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Index()

        {

            return View(await db.Students.ToListAsync());

        }

        public IActionResult Create()

        {

            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Create(Student student)

        {

            db.Students.Add(student);

            await db.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }

}