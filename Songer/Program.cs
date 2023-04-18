using Microsoft.EntityFrameworkCore;
using Songer.DAL;
using Songer.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IGenresService, GenresService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
    );

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
