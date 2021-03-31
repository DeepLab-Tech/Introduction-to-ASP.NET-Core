using CourseProjectRecap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProjectRecap.Data
{
    public class StudentConfig:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);
            builder.Property(p => p.FirstName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.LastName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EnrollmentDate).HasColumnType("Date").HasDefaultValueSql("GetDate()");
        }
    }
}