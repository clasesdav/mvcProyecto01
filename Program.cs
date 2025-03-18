using Microsoft.EntityFrameworkCore;
using mvcProyecto.Data;

var builder = WebApplication.CreateBuilder(args);

// agregar la cadena de coneccion al archivo dbcontext

var connectionString = builder.
    Configuration.
    GetConnectionString
    ("ConexionSQL") ?? 
    throw new InvalidOperationException    
    ("coneccion string 'ConexionSQL' no encontrada");

builder.Services.AddDbContext<ApplicationDbContext>(options=>
options.UseSqlServer (connectionString));

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
