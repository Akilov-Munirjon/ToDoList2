using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities;
using ToDoList2.Domain.Entities.Models;

public class PhoneConnectorConfiguration : IEntityTypeConfiguration<PhoneConnector>
{
    public void Configure(EntityTypeBuilder<PhoneConnector> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
               .HasMaxLength(100)
               .IsRequired();


        builder.HasMany(p => p.Phones)
                  .WithOne(p => p.PhoneConnector)
                  .HasForeignKey(p => p.PhoneConnectorId);
    }
}