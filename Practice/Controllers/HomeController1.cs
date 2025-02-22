using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index( Calculation c )
        {
            int num1 = c.num1;
            int num2 = c.num2;
            int result = num1 + num2;
            ViewBag.result = result;
            return View();
        }
    }
}
