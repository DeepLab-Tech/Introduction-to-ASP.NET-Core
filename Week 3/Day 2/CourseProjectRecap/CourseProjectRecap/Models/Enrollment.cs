namespace CourseProjectRecap.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public Grade Grade { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }

    public enum Grade
    {
        None=0,
        A=1,
        B=2,
        C=3,
        D=4,
        F=5
    }
}