using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1954, 12, 01)
            };
            return View(data);
        }
    }
}
