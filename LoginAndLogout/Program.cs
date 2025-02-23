using LoginAndLogout.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();  // ✅ Enable session support
builder.Services.AddHttpContextAccessor(); // ✅ Allows access to HttpContext in controllers

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("EmployeePortal");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString ?? throw new InvalidOperationException("Connection string not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // ✅ Missing session middleware (now added)

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HandleEmployee}/{action=Login}/{id?}");

app.Run();
