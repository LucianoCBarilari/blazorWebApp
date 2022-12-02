using blazorwebapp;
using blazorwebapp.Data;
using blazorwebapp.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<ExperiencialaboralService>();


//var connectionString = builder.Configuration.GetConnectionString("MySqlConnection") ?? throw new NullReferenceException("test connection string");
//builder.Services.AddSingleton(connectionString);
var connectionString = builder.Configuration.GetConnectionString("MySqlConnection") ?? throw new NullReferenceException("test connection string");

builder.Services.AddDbContextFactory<Portweb>((DbContextOptionsBuilder options)=> options.UseSqlServer(connectionString));


//builder.Services.AddScoped<IAcercaDeRepository,AcercaDeRepository>();


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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
