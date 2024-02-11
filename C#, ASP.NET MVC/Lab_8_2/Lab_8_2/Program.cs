var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();



app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "idea",
    pattern: "About/{num:int}",
    defaults: new { controller = "idea", action = "About" });
app.MapControllerRoute(
    name: "index",
    pattern: "in",
    defaults: new { controller = "Home", action = "Index" });

app.Run();