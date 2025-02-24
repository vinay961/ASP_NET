using LoginAndLogout.Data;
using LoginAndLogout.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LoginAndLogout.Controllers
{
    public class HandleEmployee : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HandleEmployee(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var credentials = await dbContext.Employees
                                                 .FirstOrDefaultAsync(e => e.Email == login.Email);

                if (credentials == null || credentials.Password != login.Password)
                {
                    ViewBag.Error = "Login Failed";
                    ModelState.Clear();
                    return View();
                }
                else
                {
                    if (login.Email != null)
                    {
                        HttpContext.Session.SetString("username", login.Email);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session?.Clear();
            return RedirectToAction("Login", "HandleEmployee");
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeViewModel emp)
        {
            if (string.IsNullOrWhiteSpace(emp?.Name))
            {
                ModelState.AddModelError(nameof(emp.Name), "Name is required");
                ViewBag.Error1 = "*";
            }
            if (string.IsNullOrWhiteSpace(emp?.Email))
            {
                ModelState.AddModelError(nameof(emp.Email), "Email is required");
                ViewBag.Error2 = "*";
            }
            if (string.IsNullOrWhiteSpace(emp?.Password))
            {
                ModelState.AddModelError(nameof(emp.Password), "Password is required");
                ViewBag.Error3 = "*";
            }

            if (ModelState.IsValid == true)
            {
                var employee = new Employee
                {
                    Name = emp.Name,
                    Email = emp.Email,
                    Password = emp.Password,
                    Present = emp.Present,
                };
                await dbContext.Employees.AddAsync(employee);
                await dbContext.SaveChangesAsync();
                ModelState.Clear();
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var emp = await dbContext.Employees.ToListAsync();
            return View(emp);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var emp = await dbContext.Employees.FindAsync(id);
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            var emp = await dbContext.Employees.FindAsync(employee.Id);
            if(emp is not null)
            {
                emp.Id = employee.Id;
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Present = employee.Present;
            }
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "HandleEmployee");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var emp = await dbContext.Employees.FindAsync(id);
            if(emp is not null)
            {
                dbContext.Employees.Remove(emp);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "HandleEmployee");
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchBy, string search)
        {
            if (searchBy == "Name")
            {
                //var data = await dbContext.Employees.Where(model => model.Name == search).ToListAsync();
                var data = await dbContext.Employees.Where(model => model.Name.StartsWith(search)).ToListAsync();
                return View(data);
            }
            else if(searchBy == "Email")
            {
                var data = await dbContext.Employees.Where(model => model.Email == search).ToListAsync();
                return View(data);
            }
            else
            {
                var data = await dbContext.Employees.ToListAsync();
                return View(data);
            }
        }
    }
}
