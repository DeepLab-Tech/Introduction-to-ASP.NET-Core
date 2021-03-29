using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectRecap.Data;
using CourseProjectRecap.Models;
using CourseProjectRecap.Services.IRepository;

namespace CourseProjectRecap.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public CourseController(ApplicationDbContext context, ICourseRepository courseRepository, IDepartmentRepository departmentRepository)
        {
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            //var tumKurslar = _context.Courses.ToList();

            //var sorgu = from dept in _context.Department
            //    join course in _context.Courses on dept.DepartmentId equals course.DepartmentId
            //    select course;

            var tumkurs = _courseRepository.CoursesToDepartment();




            return View(tumkurs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentRepository.GetAll();
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost(Course model)
        {
            if (ModelState.IsValid)
            {
                _courseRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var kurs = _courseRepository.GetById(id);
            if (kurs==null)
            {
                // Siz olsanız ne yaparsınız.
                return NotFound();
            }

            ViewBag.Department = _departmentRepository.GetAll();
            return View(kurs);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Course model)
        {
            if (ModelState.IsValid)
            {
                _courseRepository.Update(model);
                return RedirectToAction("Index");
            }

            return View("Edit");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var kurs = _courseRepository.GetById(id);
            if (kurs == null)
            {
                return NotFound();
            }

            return View(kurs);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var kurs = _courseRepository.GetById(id);
            if (kurs == null && id == 0)
            {
                return NotFound();
            }
            _courseRepository.Delete(kurs);
            return RedirectToAction("Index");
        }


    }
}
