using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysGirlsApplication.Areas.Boy.Controllers
{
    //Specifying area 
    [Area("Boy")]
    public class HomeController : Controller
    {
        //Assign the viewbag values to properties 
        //Index method to display the view index

        public IActionResult Index()
            {
            ViewBag.Name2 = "BOYS";
            ViewBag.Message2 = "There is 16 boys";
            return View();
            }        

    }
}
