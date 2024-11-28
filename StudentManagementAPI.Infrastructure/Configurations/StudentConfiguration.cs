using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementAPI.Data.Entities;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.ID);

        builder.Property(s => s.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.HasOne(s => s.Group)
               .WithMany(g => g.Students)
               .HasForeignKey(s => s.GroupID)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Attendances)
               .WithOne(a => a.Student)
               .HasForeignKey(a => a.StudentId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Payments)
               .WithOne(fp => fp.Student)
               .HasForeignKey(fp => fp.StudentID)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
