var builder = WebApplication.CreateBuilder(args);

// Додавання підтримки контролерів з поданнями

builder.Services.AddControllersWithViews();

var app = builder.Build();

// встановлюємо зіставлення маршрутів із контролерами

app.MapControllerRoute(

name: "default",

pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();