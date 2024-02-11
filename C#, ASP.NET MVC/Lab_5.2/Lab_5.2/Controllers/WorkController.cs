using Lab_5.Models;
using Lab_5.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab_5.Controllers

{

    public class WorkController : Controller

    {

        List<Worker> workers;

        List<Company> companies;

        List<string> countries = new List<string>() { 
            "USA", "Czech Republic",  "Ukraine"
        };
        public WorkController()

        {

            Company microsoft = new Company(1, "Microsoft", countries[0]);

            Company google = new Company(2, "Google", countries[0]);

            Company jetbrains = new Company(3, "JetBrains", countries[1]);

            companies = new List<Company> { microsoft, google, jetbrains };

            workers = new List<Worker>

{

new Worker(1, "Tom", 37, microsoft, microsoft.Country),

new Worker(2, "Bob", 41, microsoft, countries[2]),

new Worker(3, "Sam", 28, google, google.Country),

new Worker(4, "Bill", 32, google, countries[2]),

new Worker(5, "Kate", 33, jetbrains, jetbrains.Country),

new Worker(6, "Alex", 25, jetbrains, jetbrains.Country),
new Worker(7, "Rostyslav", 19, jetbrains, countries[0]),


};

        }

        public IActionResult Index(int? companyId)

        {

            // формуємо список компаній для передачі до подання

            List<CompanyModel> compModels = companies

            .Select(c => new CompanyModel(c.Id, c.Name)).ToList();

            // додаємо на перше місце

            compModels.Insert(0, new CompanyModel(0, "Всі"));

            IndexViewWorkModel viewModel = new() { Companies = compModels, Workers = workers };

            // якщо передано id компанії, фільтруємо список

            if (companyId != null && companyId > 0)

                viewModel.Workers = workers.Where(p => p.Company.Id == companyId);

            return View(viewModel);

        }

    }

}