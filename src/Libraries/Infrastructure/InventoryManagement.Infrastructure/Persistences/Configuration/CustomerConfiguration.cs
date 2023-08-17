using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Model;
using InventoryManagement.Shared.Enum;

namespace InventoryManagement.Infrastructure.Persistences.Configuration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");
        builder.HasKey(x => x.Id);
        builder.HasData(new
        {
            Id = 1,
            CustomerName = "Rumi",
            CustomerEmail = "tactsotft@gmail.com",
            CustomerPhone = "01646928869",
            CustomerCity = "Dhaka",
            Created = DateTimeOffset.Now,
            CreatedBy = "1",
            Status = EntityStatus.Created
        });
    }
}
