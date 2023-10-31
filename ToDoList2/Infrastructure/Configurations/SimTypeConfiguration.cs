using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Configurations
{
    public class SimTypeConfiguration : IEntityTypeConfiguration<Simtype>
    {
        public void Configure(EntityTypeBuilder<Simtype> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(p => p.Phones)
                  .WithOne(p => p.Simtype)
                  .HasForeignKey(p => p.Simtype);
        }
    }
}