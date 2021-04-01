using System.Collections.Generic;
using CourseProjectRecap.Models;

namespace CourseProjectRecap.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}