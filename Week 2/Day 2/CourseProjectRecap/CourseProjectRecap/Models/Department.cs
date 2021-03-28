using System.Collections;
using System.Collections.Generic;

namespace CourseProjectRecap.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public decimal Budget { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}