using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class DisplayQualityConfiguration : IEntityTypeConfiguration<Display>
    {
        public void Configure(EntityTypeBuilder<Display> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.DisplayQualityId)
                   .IsRequired();
        }
    }
}