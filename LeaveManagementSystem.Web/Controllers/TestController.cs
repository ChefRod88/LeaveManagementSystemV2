using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel()
            {
                Name = "Rodney Chery",
                DateOfBirth = new DateTime(1988,08,16)
            };
            return View(data);
        } 
    }
}
