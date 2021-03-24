using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReturnTypesAction.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Net.Http.Headers;

namespace ReturnTypesAction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _environment;

        public HomeController(ILogger<HomeController> logger,IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ContentResult GreetUser()
        {
            return Content("Hello world From MVC Core");
            //return Content("<div><b>Hello world From MVC Core</b></div>", "text/html");
            //return Content("<div><b>Hello world From MVC Core</b></div>", "text/xml");

            //return (Content(_environment.ContentRootPath));
            //return (Content(_environment.WebRootPath));
        }

        public ViewResult WishUser(string Message = "Default Message")
        {
            ViewBag.Message = Message;
            ViewBag.Uyari = "Şuanda RederictToAction Çalıştı...";
            return View();
        }

        public RedirectResult GotoURL()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GotoURLPer()
        {
            return RedirectPermanent("http://www.google.com");
        }

        public RedirectToActionResult GotoContactsAction()
        {
            return RedirectToAction("WishUser", new {Message = "Bu işlemde farklı bir action yönlendirmesi var..."});
        }

        public RedirectToRouteResult GotoAbout()
        {
            return (RedirectToRoute("WishUser"));
        }

        public FileResult DownloadFile()
        {
            return File("/css/site.css", "text/plain", "newsite.css");
        }

        public FileResult ShowLogo()
        {
            return File("./Images/logo.png", "images/png");
        }

        public FileContentResult DownloadContent()
        {
            //var file = System.IO.File.ReadAllBytes("./wwwroot/css/site.css");
            //return new FileContentResult(file,"text/plain");

            var file = System.IO.File.ReadAllBytes("./Data/Products.xml");
            return new FileContentResult(file,"text/xml");
        }

        public FileStreamResult CreateFile()
        {
            var stream = new MemoryStream(Encoding.ASCII.GetBytes("DeeplabBootcamp"));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {
                FileDownloadName = "test.txt"
            };
        }

        public JsonResult ShowNewProducts()
        {
            Products products = new Products() {ProductCode = 101, ProductName = "Printer", Cost = 1500};
            return Json(products);
        }

        public BadRequestResult BRRDemo()
        {
            return BadRequest();
        }

        public StatusCodeResult ReturnBadResult()
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }

        public BadRequestObjectResult BadRequestObjectResultDemo()
        {
            var modelstate = new ModelStateDictionary();
            modelstate.AddModelError("br","Bad Request");
            return BadRequest(modelstate);
        }

        public UnauthorizedResult UnauthorizedResultDemo()
        {
            return Unauthorized();
        }

        public UnauthorizedObjectResult UnauthorizedObjectResultDemo()
        {
            var modelstate = new ModelStateDictionary();
            modelstate.AddModelError("br","Bu sayfaya erişim yetkiniz bulunmuyor");
            return Unauthorized(modelstate);
        }

        public NotFoundResult ReturnNotFound()
        {
            return NotFound();
        }

        public NotFoundObjectResult NotFoundObjectResultDemo()
        {
            return NotFound(new {CustomerId = 1, error = "Müşteri ID'si Bulunamadı"});
        }

        public OkObjectResult ReturnOk()
        {
            return Ok(new string[] {"O", "K", "A", "Y"});
        }

        public OkObjectResult OkObjectResultDemo()
        {
            return new OkObjectResult(new {Message = "OKAY!!"});
        }




    }
}
