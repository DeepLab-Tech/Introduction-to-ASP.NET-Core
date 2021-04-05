using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace DataAccess.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.StudentId);
            builder.Property(x => x.StudentName).HasMaxLength(50);
            builder.Property(x => x.StudentSurname).HasMaxLength(50);
            builder.Property(x => x.StudentNumber).HasMaxLength(5);
            builder.Property(x => x.StudentClassRoom).HasMaxLength(10);

            builder.HasMany(c => c.Courses)
                .WithMany(s => s.Students);
        }
    }
}