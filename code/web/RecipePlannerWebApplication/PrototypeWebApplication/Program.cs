using MySqlConnector;
using PrototypeWebApplication.Data;
using PrototypeWebApplication.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    //options.UseMySql("Server=localhost;Database=names_list;uid=root;pwd=passwordpassword123;");
});
//builder.Services.AddTransient<MySqlConnection>(_ =>
//    new MySqlConnection(builder.Configuration.GetConnectionString("Default")));

//builder.Services.Add(new ServiceDescriptor(typeof(NamesContext), new NamesContext(builder.Configuration.GetConnectionString("Default"))));

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
