using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithViewBag.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UrunAdi = "Samsung Cep Telefonu";
            ViewBag.Kategori = "Elektronik";
            ViewBag.Adet = "30";
            ViewBag.Fiyat = "4500";
            return View();
        }

        public IActionResult QueryStringEx(string message = "Query String Örnek")
        {
            ViewBag.Deneme = message;
            return View();
        }

        [HttpGet]
        public IActionResult URLGit(string url = "http://www.google.com")
        {
            return (Redirect(url));
        }
    }
}
