using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace DataAccess.Config
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DepartmentId);
            builder.Property(x => x.DepartmentName).HasMaxLength(25);

            builder.HasMany(c => c.Courses)
                .WithOne(d => d.Department)
                .HasForeignKey(c => c.CourseId);

            builder.HasMany(t => t.Teachers)
                .WithOne(d => d.Department)
                .HasForeignKey(t => t.TeacherId);
        }
    }
}