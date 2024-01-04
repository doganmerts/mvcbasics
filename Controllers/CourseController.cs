using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcbasics.Models;

namespace mvcbasics.Controllers
{
   
    public class CourseController : Controller
    {
        

        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "AspNet Core 7.0";
            course.Description= "Gayet İyi :)";
            course.Image = "4.jpg";
            return View(course);
        }

        public IActionResult Details(int id)
        {
            if(id == null || id == 0 ){
                return Redirect("course/list");
                return RedirectToAction("List");
            }
            var course = Repository.GetCourseById(id);
            return View(course);
        }

        public IActionResult List()
        {
          
            return View("CourseList", Repository.Courses);
        }    
    }
}