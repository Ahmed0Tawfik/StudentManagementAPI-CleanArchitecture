using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementAPI.Data.Entities;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.ID);

        builder.Property(g => g.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.HasMany(g => g.LectureDays)
               .WithOne(ld => ld.Group)
               .HasForeignKey(ld => ld.GroupID)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
