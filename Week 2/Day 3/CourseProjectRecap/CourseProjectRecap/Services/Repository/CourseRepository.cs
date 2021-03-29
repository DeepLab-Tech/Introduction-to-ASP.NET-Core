using System.Collections.Generic;
using System.Linq;
using CourseProjectRecap.Data;
using CourseProjectRecap.Models;
using CourseProjectRecap.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectRecap.Services.Repository
{
    public class CourseRepository:Repository<Course>,ICourseRepository
    {
        public CourseRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public IEnumerable<Course> CoursesToDepartment()
        {
            return ApplicationDbContext.Courses.Include(x => x.Department).ToList();
        }
    }
}