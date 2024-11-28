using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementAPI.Data.Entities;

public class LectureDayConfiguration : IEntityTypeConfiguration<LectureDay>
{
    public void Configure(EntityTypeBuilder<LectureDay> builder)
    {
        builder.HasKey(ld => ld.ID);

        builder.HasOne(ld => ld.Group)
               .WithMany(g => g.LectureDays)
               .HasForeignKey(ld => ld.GroupID)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(ld => ld.DayOfWeek)
               .IsRequired();
    }
}
