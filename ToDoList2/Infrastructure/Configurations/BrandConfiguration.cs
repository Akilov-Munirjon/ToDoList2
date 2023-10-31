using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(b => b.Address)
                   .IsRequired();


            builder.HasOne(b => b.Address)
                   .WithMany(p => p.Phone)
                   .HasForeignKey(p => p.BrandId);
        }
    }
}