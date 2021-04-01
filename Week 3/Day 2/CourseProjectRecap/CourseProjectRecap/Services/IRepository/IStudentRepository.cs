using System.Collections.Generic;
using CourseProjectRecap.Models;

namespace CourseProjectRecap.Services.IRepository
{
    public interface IStudentRepository:IRepository<Student>
    {
        IEnumerable<Enrollment> CoursesToStudent(int studentId);
    }
}