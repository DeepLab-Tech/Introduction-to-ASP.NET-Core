using CourseProjectRecap.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProjectRecap.Data
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(k => k.DepartmentId);
            builder.Property(p => p.DepartmentId).ValueGeneratedOnAdd();
            builder.Property(p => p.DepartmentName).IsRequired().HasColumnType("Nvarchar(50)");
            builder.Property(p => p.Budget).IsRequired();


            builder.HasMany(m => m.Courses)
                .WithOne(o => o.Department)
                .HasForeignKey(f => f.DepartmentId);
        }
    }
}