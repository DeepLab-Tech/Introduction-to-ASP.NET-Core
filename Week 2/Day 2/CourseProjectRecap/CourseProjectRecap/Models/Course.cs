using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProjectRecap.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Lütfen Kurs Başlığını Giriniz")]
        public string CourseName { get; set; }
        public int Credit { get; set; }

        //Yabancı Anahtar Department Tablosu (İlişkilendirme İşlemi)
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}