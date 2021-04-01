using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseProjectRecap.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        [Display(Name = "Kayıt Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd,MM,yyyy}",ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }

    public enum Gender
    {
        Male=1,
        Female=2
    }
}