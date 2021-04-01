using System.Collections.Generic;
using System.Linq;
using CourseProjectRecap.Data;
using CourseProjectRecap.Models;
using CourseProjectRecap.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectRecap.Services.Repository
{
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public IEnumerable<Enrollment> CoursesToStudent(int studentId)
        {
            return ApplicationDbContext.Enrollments
                .Where(e => e.StudentId == studentId)
                .Include(x => x.Student)
                .Include(x => x.Course)
                .ToList();
        }
    }
}