var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseRouting(); // Додайте цей метод для налаштування маршрутизації.

app.UseEndpoints(endpoints =>
{
    /*a) Додаткові параметри шаблону маршруту:*/
    endpoints.MapControllerRoute(
    name: "custom",
    pattern: "custom/{controller}/{action}/{customParam}");
    /*b) Статичні сегменти:c) Необов'язкові параметри маршрутів:(id)d) Значення параметрів за замовчуванням:
     controller=Home*/
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "static/{controller=Home}/{action=Index}/{id?}");
    /*f) Параметри defaults методу MapControllerRoute():*/
    endpoints.MapControllerRoute(
        name: "ID",
        pattern: "ID/{action}",
        defaults: new { controller = "ID" });
});


app.Run();