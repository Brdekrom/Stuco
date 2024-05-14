using Stuco.Application;
using Stuco.Application.Features.GetKlanten.Abstraction;
using Stuco.Application.Features.Projecten.Abstractions;
using Stuco.Application.Features.Stukadoren.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddApplicationServices();

builder.Services.AddAuthentication();

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();  // Make sure this line is present

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Stuco", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stuco v1"));

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapGet("/klant", (IGetAllKlanten getAllKlanten) =>
{
    return getAllKlanten.Execute();
});

app.MapGet("/klant/{id:int}", (int id, IGetKlant getKlant) =>
{
    return getKlant.Execute(id);
});

app.MapGet("/project", (IGetAllProjecten getAllProjecten) =>
{
    return getAllProjecten.Execute();
});

app.MapGet("/project/{id:int}", (int id, IGetProject getProject) =>
{
    return getProject.Execute(id);
});

app.MapGet("/stukadoor", (IGetAllStukadoren getAllStucadoren) =>
{
    return getAllStucadoren.Execute();
});

app.MapGet("/stukadoor/{id:int}", (int id, IGetStukadoor getStukadoor) =>
{
    return getStukadoor.Execute(id);
});

app.Run();