using Domain.RepositoriesInterfaces;
using Domain.UseCases;
using Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

builder.Services.AddScoped<IPersonaRepository, PersonaRepository>(); 
builder.Services.AddScoped<IPersonaRepositoryUseCase, PersonaRepositoryUseCase>();

