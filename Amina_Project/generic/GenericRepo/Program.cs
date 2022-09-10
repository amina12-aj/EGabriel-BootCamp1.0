using GenericRepo.DataAccess;
using GenericRepo.Models;
using GenericRepo.Repository.BlogProject.Repository;
using Microsoft.EntityFrameworkCore;
using static GenericRepo.Repository.Repocs;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Blog");
builder.Services.AddDbContextPool<ApplicationDbContext>(option =>
option.UseSqlServer(connectionString));


builder.Services.AddScoped<IRepo<Role>, Repo<Role>>();
builder.Services.AddScoped<IRepo<Blog>, Repo<Blog>>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
