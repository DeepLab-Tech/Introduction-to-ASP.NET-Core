using System.Collections.Generic;

namespace Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}