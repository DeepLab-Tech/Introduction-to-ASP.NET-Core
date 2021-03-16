using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecapAspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hakkimizda()
        {
            return "Hakkımızda";
        }

        public string UrunListesi()
        {
            return "Ürün Listesi";
        }
    }
}
