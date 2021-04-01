using CourseProjectRecap.Data;
using CourseProjectRecap.Models;
using CourseProjectRecap.Services.IRepository;

namespace CourseProjectRecap.Services.Repository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}