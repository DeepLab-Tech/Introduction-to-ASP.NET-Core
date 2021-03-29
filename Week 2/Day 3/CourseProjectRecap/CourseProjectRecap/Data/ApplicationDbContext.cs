using CourseProjectRecap.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectRecap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Courses { get; set; }
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
        }
    }
}