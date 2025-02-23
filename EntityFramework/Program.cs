using EntityFramework.Models;
using Microsoft.EntityFrameworkCore; // Required for database operations
using Microsoft.Extensions.Configuration; // Allows reading from configuration files
using Microsoft.Extensions.DependencyInjection; // Provides dependency injection support
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

var builder = WebApplication.CreateBuilder(args); // Creates a new instance of the web application builder

// Add services to the container.
builder.Services.AddControllersWithViews(); // Registers MVC controllers and views for handling web requests

// 🔹 Step 1: Get the connection string from `appsettings.json`
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 🔹 Step 2: Register the database context and configure MySQL
builder.Services.AddDbContext<StudentContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
// `StudentContext` is your custom class that represents the database
// `UseMySql` tells Entity Framework Core to use MySQL as the database
// `ServerVersion.AutoDetect` automatically detects the MySQL server version

var app = builder.Build(); // Builds the application and prepares it for execution

// 🔹 Step 3: Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment()) // Checks if the app is running in a production environment
{
    app.UseExceptionHandler("/Home/Error"); // Redirects to the error page if an exception occurs
    app.UseHsts(); // Enables HTTP Strict Transport Security (HSTS) to enforce HTTPS
}

app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS
app.UseStaticFiles(); // Serves static files like CSS, JavaScript, and images

app.UseRouting(); // Enables routing, so URLs can map to controllers and actions

app.UseAuthorization(); // Enables authentication and authorization

// 🔹 Step 4: Define the default routing pattern
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// This means:
// - If no controller is specified in the URL, `HomeController` will be used
// - If no action is specified, the `Index` action method will be called
// - `id?` means `id` is optional (can be present or not)

app.Run(); // Starts the application and listens for incoming HTTP requests
