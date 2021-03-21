using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace WorkingWithController.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Account()
        {
            return "Burası String Dönen Admin Controller Account Action";
        }

        public ViewResult İletisim()
        {
            return View();
        }

        public ViewResult Hakkimizda()
        {
            return View();
        }

        public ViewResult Services()
        {
            return View("Servisler");
        }

        // Passing Data 
        public ViewResult PassData()
        {
            int hour = DateTime.Now.Hour;
            string viewmodel = hour > 12 ? "İyi Günler" : "Günaydın";
            return View("Servisler", viewmodel);
        }

    }
}
