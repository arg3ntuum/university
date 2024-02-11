using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers

{

    public class HomeController : Controller

    {
        public string IndexA(string name) => $"Your name: {name}";

        public string IndexB(Person[] people)

        {

            string result = "";

            foreach (Person person in people)

            {

                result = $"{result} {person.Name}; ";

            }

            return result;

        }
        public async Task Index()

        {

            string form = @"<form method='post'>
            <p>
            Person1 Name:<br/>
            <input name='people[0].name' /><br/>
            Person1 Age:<br/>
            <input name='people[0].age' />
            </p>
            <p>
            Person2 Name:<br/>
            <input name='people[1].name' /><br/>
            Person2 Age:<br/>
            <input name='people[1].age' />
            </p>
            <input type='submit' value='Send' />
            </form>";

            Response.ContentType = "text/html;charset=utf-8";

            await Response.WriteAsync(form);

        }

        [HttpPost]

        public string Index(Person[] people)
        {
            string result = "";

            foreach (Person person in people)
                result = $"{result} \n{person}";
            return result;
        }
    }

    public record class Person(string Name, int Age);

}