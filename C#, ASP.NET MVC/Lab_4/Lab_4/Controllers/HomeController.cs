using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers

{

    public class HomeController : Controller

    {

        public string Index() => "Я, Шейко Ростислав Олександрович, студент групи КІ-21-2, навчаюсь на третьому курсі. Університет: ДНУ.";

        public string About() => "За допомогою сучасної технології ASP.NET Core\r\nстворюються кросплатформені додатки які можуть\r\nпрацювати в операційних системах Windows, Linux і Mac\r\nOS. Ефективна MVC розробка веб-додатків забезпечує\r\nрозподіл функціональностей, що спрощує тестування,\r\nмодифікацію та супровід.";

    }

}