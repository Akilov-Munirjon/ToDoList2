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

        /*builder.Property(p => p.ConnectorId)
               .HasMaxLength(100)
               .IsRequired();*/

        builder.HasOne(p => p.Phone)
             .WithMany(p => p.PhoneConnector)
             .HasForeignKey(p => p.PhoneId);

        /*builder.HasOne(p => p.Connector)
             .WithMany(p => p.PhoneConnector)
             .HasForeignKey(p => p.ConnectorId);*/

    }
}