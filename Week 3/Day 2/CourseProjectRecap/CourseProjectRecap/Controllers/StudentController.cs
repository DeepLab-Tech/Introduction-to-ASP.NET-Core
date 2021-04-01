using System.Linq;
using CourseProjectRecap.Migrations;
using CourseProjectRecap.Services.IRepository;
using CourseProjectRecap.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using ReflectionIT.Mvc.Paging;

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
        public IActionResult Index(string sortOrder,string searchString,int pageIndex=1)
        {
            #region Sıralama ve Arama İşlemleri
            //if (string.IsNullOrEmpty(sortOrder))
            //{
            //    ViewData["sortName"] = "name_desc";
            //}
            //else
            //{
            //    ViewData["sortName"] = "";
            //}

            ViewData["sortName"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["sortByDate"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["currentFilter"] = searchString;

            var ogrenciler = _studentRepository.GetAll();
            if (!string.IsNullOrEmpty(searchString))
            {
                ogrenciler = ogrenciler.Where(s => s.FirstName.ToLower().Contains(searchString.ToLower()) ||
                                                   s.LastName.ToLower().Contains(searchString.ToLower()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    ogrenciler = ogrenciler.OrderByDescending(s => s.FirstName);
                    break;
                case "Date":
                    ogrenciler = ogrenciler.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    ogrenciler = ogrenciler.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    ogrenciler = ogrenciler.OrderBy(s => s.FirstName);
                    break;
            } 
            #endregion

            var model = PagingList.Create(ogrenciler, 2, pageIndex);

            return View(model);
        }

        public IActionResult Details(int id = 0)
        {
            if (id==0)
            {
                return NotFound();
            }

            var ogrenci = _studentRepository.GetById(id);
            var model = new StudentViewModel()
            {
                Student = ogrenci,
                Enrollments = _studentRepository.CoursesToStudent(ogrenci.StudentId)
            };
            return View(model);
        }


    }
}