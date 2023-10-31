using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class BatteryConfiguration : IEntityTypeConfiguration<Battery>
    {
        public void Configure(EntityTypeBuilder<Battery> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(b => b.Capacity)
                   .IsRequired();


            builder.HasOne(p => p.Battery)
                 .WithMany(b => b.Phones)
                 .HasForeignKey(p => p.BatteryId);
                 
        }
    }
}