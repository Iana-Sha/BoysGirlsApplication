using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysGirlsApplication.Areas.Girl.Controllers
{
    //Specifying area
    [Area("Girl")]
    public class HomeController : Controller
    {
        //Assign the viewbag values to properties 
        //Index method to display the view index

        public IActionResult Index()
        {
            ViewBag.Name2 = "GIRLS";
            ViewBag.Message2 = "There is 2 girls";
            return View();
        }
    }
}
