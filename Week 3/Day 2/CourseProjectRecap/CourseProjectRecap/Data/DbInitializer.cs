using System.Collections.Generic;
using System.Linq;
using CourseProjectRecap.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CourseProjectRecap.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                if (!context.Department.Any())
                {
                    context.Department.AddRange(Departments.Values);
                }

                if (!context.Courses.Any())
                {
                    var courselist = new List<Course>
                    {
                        new Course() {CourseName = "Asp.Net Core BackEnd", Department = Departments["Programming"], Credit = 10},
                        new Course() {CourseName = "Asp.Net Core BackEnd", Department = Departments["Design"], Credit = 10},
                        new Course() {CourseName = "Asp.Net Core BackEnd", Department = Departments["Network"], Credit = 10}
                    };
                    context.Courses.AddRange(courselist);
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Department> _departments;

        public static Dictionary<string, Department> Departments
        {
            get
            {
                if (_departments != null)
                {
                    return _departments;
                }

                var deptList = new[]
                {
                    new Department() {DepartmentName = "Programming"},
                    new Department() {DepartmentName = "Design"},
                    new Department() {DepartmentName = "Network"}
                };

                _departments = new Dictionary<string, Department>();
                foreach (var department in deptList)
                {
                    _departments.Add(department.DepartmentName,department);
                }

                return _departments;

            }
        }
    }
}