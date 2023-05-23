using MovieApp.Controllers;
using MovieApp.Models;
using MovieApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ImdbApiService>();
builder.Services.AddScoped<DatabaseService>();
builder.Services.AddScoped<MovieApiController>();
builder.Services.AddDbContext<MovieAppDbContext>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();