using System.Collections.Generic;

namespace Models
{
    public class Department : Base.Base
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}