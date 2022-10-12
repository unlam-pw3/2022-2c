using EnciclopediaDarwin.Data.Entidades;
using EnciclopediaDarwin.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<_20222CEnciclopediaDarwinContext>();
builder.Services.AddScoped<IEspecieServicio, EspecieServicio>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Especies}/{action=Lista}/{id?}");

app.MapDefaultControllerRoute();
app.MapRazorPages();
app.Run();
