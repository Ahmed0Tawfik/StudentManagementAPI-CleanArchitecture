using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementAPI.Data.Entities;

public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
{
    public void Configure(EntityTypeBuilder<Attendance> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasOne(a => a.Student)
               .WithMany(s => s.Attendances)
               .HasForeignKey(a => a.StudentId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(a => a.Group)
               .WithMany()
               .HasForeignKey(a => a.GroupId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.Property(a => a.LectureDate)
               .IsRequired();

        builder.Property(a => a.IsPresent)
               .IsRequired();
    }
}
