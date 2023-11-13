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

            builder.HasOne(p => p.Battery)
                .WithMany(p => p.Phones)
                .HasForeignKey(p =>p.BatteryId);


            builder.HasOne(p => p.Brand)
                .WithMany(p => p.Phones)
                .HasForeignKey(p => p.BrandId);


            builder.HasOne(p => p.Camera)
               .WithMany(p => p.Phones)
               .HasForeignKey(p => p.CameraId);


            builder.HasOne(p => p.Cpu)
                 .WithMany(c => c.Phones)
                 .HasForeignKey(p => p.CpuId);

            builder.HasOne(d => d.Display)
                .WithMany(d => d.Phones)
                .HasForeignKey(d => d.DisplayId);


            builder.HasOne(p => p.Memory)
                 .WithMany(p => p.Phones)
                 .HasForeignKey(p => p.MemoryId);


            builder.HasOne(p => p.Os)
                  .WithMany(p => p.Phones)
                  .HasForeignKey(p => p.OsId);


            builder.HasMany(p => p.PhoneConnector)
                   .WithOne(o => o.Phone)
                   .HasForeignKey(p => p.PhoneId);


            builder.HasOne(p => p.SimType)
                 .WithMany(p => p.Phones)
                 .HasForeignKey(p => p.SimTypeId);







        }
    }
}