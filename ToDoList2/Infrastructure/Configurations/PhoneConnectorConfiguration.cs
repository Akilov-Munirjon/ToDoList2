using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList2.Domain.Entities;
using ToDoList2.Domain.Entities.Models;

public class PhoneConnectorConfiguration : IEntityTypeConfiguration<PhoneConnector>
{
    public void Configure(EntityTypeBuilder<PhoneConnector> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.PhoneId)
               .HasMaxLength(100)
               .IsRequired();
    }
}