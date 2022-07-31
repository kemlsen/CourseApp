using CourseApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CourseApp.Web.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good Morning";
            return View("MyView");
        }
        public ViewResult List()
        {
            var liste=Repository.Students.Where(x => x.WillAttend == true);
            return View(liste);
        }
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }
            
        }
    }
}
 