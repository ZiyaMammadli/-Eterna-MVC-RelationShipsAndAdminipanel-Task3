

using Eterna_MVC_ConnectionDBcontext_task2.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EternaDbContext>(opt =>
{
    opt.UseSqlServer("Server=WIN-PRIFU0D7GO7\\SQLEXPRESS;Database=EternaDb;Trusted_Connection=true;TrustServerCertificate=True");
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=dashboard}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );

app.Run();
