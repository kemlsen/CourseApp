using CourseApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Name = "Asp.Net Core Kursu";

            return View(course);
        }
    }
}
