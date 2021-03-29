using System.Collections.Generic;
using CourseProjectRecap.Models;

namespace CourseProjectRecap.Services.IRepository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> CoursesToDepartment();
    }
}