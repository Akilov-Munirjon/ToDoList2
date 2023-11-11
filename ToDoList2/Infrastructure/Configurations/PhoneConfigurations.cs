using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(p => p.PhoneConnector)
                   .WithOne(o => o.Phone)
                   .HasForeignKey(p => p.PhoneId);

            builder.HasOne(d => d.Display)
                .WithMany(d => d.Phones)
                .HasForeignKey(d => d.DisplayId);

        }
    }
}