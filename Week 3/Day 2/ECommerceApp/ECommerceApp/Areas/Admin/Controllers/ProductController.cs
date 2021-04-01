using System.Linq;
using ECommerceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View(_db.Products.ToList());
        }
    }
}