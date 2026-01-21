using Microsoft.EntityFrameworkCore;
using WEB_RESTAURANTE.Sesiones;
using WEB_RESTAURANTE_DATOS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
builder.Services.AddDbContext<AplicacionContexto>(options =>
                          options.UseSqlServer("name=defaultConnection"));

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddHttpContextAccessor();

var app = builder.Build();
SesionUtil.Configure(
    app.Services.GetRequiredService<IHttpContextAccessor>()
);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();/// mata el midlaware
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapStaticAssets();

//el end point es el ultimo en ejecutarse el orden importa esto ejecuta el controlador y nada mas continua 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
