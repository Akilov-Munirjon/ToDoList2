using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class DisplayQualityConfiguration : IEntityTypeConfiguration<DisplayQuality>
    {
        public void Configure(EntityTypeBuilder<DisplayQuality> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(100)
                   .IsRequired();
             
            builder.HasMany(p => p.Displayes)
                  .WithOne(p => p.Phones)
                  .HasForeignKey(p => p.DisplayQualityId);
        }
    }
}