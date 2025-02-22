using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(EmployeeModel model)
    {
        if (string.IsNullOrWhiteSpace(model?.Name))
        {
            ModelState.AddModelError(nameof(model.Name), "Name is required");
            ViewBag.Error1 = "*";
        }
        if (string.IsNullOrWhiteSpace(model?.Email))
        {
            ModelState.AddModelError(nameof(model.Email), "Email is required");
            ViewBag.Error2 = "*";
        }
        if (model?.Number == null || model.Number == 0)
        {
            ModelState.AddModelError(nameof(model.Number), "Number is required");
            ViewBag.Error3 = "*";
        }

        if (ModelState.IsValid == true) // it is false if any occur otherwise it is true
        {
            ViewBag.SuccessMessage = "User registered successfully";
            ModelState.Clear();
        }
        // We can handle these error using data annotations, which is given in model itself
        return View(); 
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
