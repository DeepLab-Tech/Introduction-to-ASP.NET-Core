using CourseProjectRecap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProjectRecap.Data
{
    public class CourseConfig:IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(k => k.CourseId);
            builder.Property(p => p.CourseId).ValueGeneratedOnAdd();
            builder.Property(p => p.Credit).IsRequired();

            //Course => Department İlişki
            builder.HasOne(d => d.Department)
                .WithMany(c => c.Courses)
                .HasForeignKey(f => f.DepartmentId);
        }
    }
}