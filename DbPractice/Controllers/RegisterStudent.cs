using DbPractice.Data;
using DbPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbPractice.Controllers
{
    public class RegisterStudent : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public RegisterStudent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(RegisterStudentViewModel viewModel)
        {
            var Student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribe = viewModel.Subscribe,
            };
            await dbContext.Students.AddAsync(Student);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);

        }

        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            var student = await dbContext.Students.FindAsync(id);

            return View(student);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.Id);
            if (student is not null)
            {
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Subscribe = viewModel.Subscribe;
                student.Name = viewModel.Name;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "RegisterStudent");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student is not null)
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "RegisterStudent");
        }
    }
}
