using System.Collections.Generic;

namespace Models
{
    public class Course : Base.Base
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int WeeklyHours { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}