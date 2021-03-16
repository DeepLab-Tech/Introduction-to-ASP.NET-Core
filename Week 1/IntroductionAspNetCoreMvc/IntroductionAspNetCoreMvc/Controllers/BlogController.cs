using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroductionAspNetCoreMvc.Models;

namespace IntroductionAspNetCoreMvc.Controllers
{
    public class BlogController : Controller
    {

        [Route("home/action/id?")]
        public IActionResult Article()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            var yazar = new BlogAuthorModel();





            var detay = new BlogModel();
            detay.Title = baslik;
            detay.Description = aciklama;
            detay.Image = resim;
            return View(detay);
        }
    }
}
