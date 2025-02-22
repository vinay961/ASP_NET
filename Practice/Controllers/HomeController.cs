using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Name"] = "Tom";
        ViewBag.Name = "Jerry";
        TempData["Name"] = "Vinay";
        return View();
    }
    public IActionResult AboutUs()
    {
        RegisterViewModel registerViewModel1 = new RegisterViewModel();
        registerViewModel1.FullName = "Vinay";
        registerViewModel1.Email = "Vinay@123";
        registerViewModel1.Password = "Password";
        registerViewModel1.ConfirmPassword = "Password";

        RegisterViewModel registerViewModel2 = new RegisterViewModel();
        registerViewModel2.FullName = "Ram";
        registerViewModel2.Email = "Ram@123";
        registerViewModel2.Password = "Password";
        registerViewModel2.ConfirmPassword = "Password";

        List<RegisterViewModel> list = new List<RegisterViewModel>();
        list.Add(registerViewModel1);
        list.Add(registerViewModel2);
        return View(list);
    }
    public IActionResult ContactUs()
    {
        Product product = new Product(1,"Adidas", "SampleProduct", "D:\\Visual-Studio\\ASP_NET\\Practice\\images\\adidas.jpg");
        Product product1 = new Product(2, "Reebok", "Sample Product", "~/images/shirt.jpg");
        Product product2 = new Product(3, "Nike", "Sample Product", "~/images/nike.jpg");

        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        products.Add(product);
        
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
