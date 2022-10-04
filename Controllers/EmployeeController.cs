using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllEmployees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            Repository.Create(employee);
            return View("Thanks", employee);
        }

        public IActionResult Update(string empname)
        {
            Employee employee = Repository.AllEmployees.FirstOrDefault(e => e.Name == empname);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            Employee employee1 = Repository.AllEmployees.FirstOrDefault(e => e.Name == empname);

            employee1.Age = employee.Age;
            employee1.Salary = employee.Salary;
            employee1.Department = employee.Department;
            employee1.Gender = employee.Gender;
            employee1.Name = employee.Name;

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Employee employee = Repository.AllEmployees.FirstOrDefault(e => e.Name == empname);
            Repository.Delete(employee);
            return RedirectToAction("Index");
        }

    }
}
