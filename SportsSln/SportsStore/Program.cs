using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();


var app = builder.Build();

// Middlewares
app.UseStaticFiles();

app.MapControllerRoute("catpage",
 "{category}/Page/{productPage:int}",
 new { Controller = "Home", Action = "Index"});

app.MapControllerRoute("page",
 "Page/{productPage:int}",
 new { Controller = "Home", Action = "Index", productPage = 1});
 
app.MapControllerRoute("category",
 "{category}",
 new { Controller = "Home", Action = "Index", productPage = "1"});
 
app.MapControllerRoute("pagination", 
                "Products/Page/{productPage}",
                new {
                    Controller = "Home",
                    Action = "Index"
                });
app.MapDefaultControllerRoute();
app.EnsurePopulated();

app.Run();