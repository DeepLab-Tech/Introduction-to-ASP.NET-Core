using CourseProjectRecap.Data;
using CourseProjectRecap.Models;
using CourseProjectRecap.Services.IRepository;

namespace CourseProjectRecap.Services.Repository
{
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}