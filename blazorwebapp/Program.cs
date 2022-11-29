using blazorwebapp;
using blazorwebapp.Data;
using blazorwebapp.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


// connectionString = builder.Configuration.GetConnectionString("default")
//?? throw new NullReferenceException("no connection string");

//builder.Services.AddDbContextFactory<Portweb>((DbContextOptionsBuilder options)=> options.UseMySQL(connectionString));

//var mySQLConfiguration = new MySqlConfiguration(builder.Configuration.GetConnectionString("MySqlConnection"));
//builder.Services.AddSingleton(mySQLConfiguration);
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
