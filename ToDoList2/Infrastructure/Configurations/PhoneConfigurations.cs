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
                   .WithMany(b => b.Phones)
                   .HasForeignKey(p => p.BatteryId);

            builder.HasOne(p => p.Brand)
                   .WithMany(b => b.Phones)
                   .HasForeignKey(p => p.BrandId);


            builder.HasOne(p => p.Camera)
                   .WithMany(c => c.Phones)
                   .HasForeignKey(p => p.CameraId);


            builder.HasOne(p => p.Cpu)
                  .WithMany()
                  .HasForeignKey(p => p.CpuId);

            builder.HasOne(p => p.Display)
                   .WithMany(d => d.Phones)
                   .HasForeignKey(p => p.DisplayId);


            builder.HasOne(p => p.Memory)
                   .WithMany(m => m.Phones)
                   .HasForeignKey(p => p.MemoryId);


            builder.HasOne(p => p.Os)
                   .WithMany(os => os.Phones)
                   .HasForeignKey(p => p.OsId);


            builder.HasOne(p => p.SimType)
                   .WithMany(st => st.Phones)
                   .HasForeignKey(p => p.SimTypeId);

        }
    }
}