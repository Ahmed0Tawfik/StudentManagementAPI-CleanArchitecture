using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagementAPI.Data.Entities;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(fp => fp.ID);

        builder.HasOne(fp => fp.Student)
               .WithMany(s => s.Payments)
               .HasForeignKey(fp => fp.StudentID)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(fp => fp.Month)
               .IsRequired()
               .HasMaxLength(12);


        builder.Property(fp => fp.Year)
               .IsRequired();

        builder.Property(fp => fp.PaymentStatus)
               .IsRequired();
    }
}
