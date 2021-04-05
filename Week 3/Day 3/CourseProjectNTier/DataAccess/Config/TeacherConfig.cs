using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace DataAccess.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.TeacherId);
            builder.Property(x => x.TeacherName).HasMaxLength(50);
            builder.Property(x => x.TeacherSurname).HasMaxLength(50);

            builder.HasOne(d => d.Department)
                .WithMany(t => t.Teachers)
                .HasForeignKey(d => d.DepartmentId);

            builder.HasMany(c => c.Courses)
                .WithOne(t => t.Teacher)
                .HasForeignKey(c => c.CourseId);

        }
    }
}