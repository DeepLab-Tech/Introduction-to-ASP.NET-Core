using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithControllersDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greetings = "Hello World From MVC Core";
            ViewBag.Company = "Udemy";
            ViewBag.Country = "India";
            return View();
        }

        public IActionResult QueryStringDemo(string Message = "Hello World From MVC Core")
        {
            ViewBag.Greetings = Message;
            return View();
        }

        [HttpGet]
        public IActionResult GotoURL(string url="http://www.google.com")
        { 
            return (Redirect(url));
        }



    }
}
