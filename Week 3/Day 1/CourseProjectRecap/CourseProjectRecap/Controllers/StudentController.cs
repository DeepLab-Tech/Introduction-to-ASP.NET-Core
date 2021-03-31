using CourseProjectRecap.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectRecap.Controllers
{
    
    public class StudentController : Controller
    {
        private IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
           _studentRepository = studentRepository;
        }

        // GET
        public IActionResult Index()
        {
            var ogrenciler = _studentRepository.GetAll();
            return View(ogrenciler);
        }

        
    }
}