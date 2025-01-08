using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestViewController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "DANIEL GARCIA V",
                BirthDate = new DateOnly(1993,04,24)
            };
            return View(data);
        }
    }
}
