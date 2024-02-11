var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // додаємо підтримку контролерів

var app = builder.Build();

// встановлюємо зіставлення маршрутів із контролерами

app.MapControllerRoute(

    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();