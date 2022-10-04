using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

        public IActionResult Info() 
        {
           Person person = new Person
            {
                Name = "Ali",
                Age = 52,
                Location = "İstanbul"
            };

            return View(person);
        }
    }
}
//http://localhost:5139/first/