using System.Collections.Generic;

namespace Models
{
    public class Student : Base.Base
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentNumber { get; set; }
        public string StudentClassRoom { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}