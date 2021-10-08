using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysGirlsApplication.Areas.Teacher.Controllers
{
    //Specifying area
    [Area("Teacher")]
    public class HomeController : Controller
    {
        //Assign the viewbag values to properties 
        //Index method to display the view index
        public IActionResult Index()
        {
            ViewBag.Name3 = "TEACHERS";
            ViewBag.Message3 = "There is 1 teacher";
            return View();
        }
    }
}
