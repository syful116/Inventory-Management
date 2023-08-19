using InventoryManagement.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.Persistences.Configuration;


public class SellsConfiguration : IEntityTypeConfiguration<Sells>
{
    public void Configure(EntityTypeBuilder<Sells> builder)
    {
        builder.ToTable("Sells");
        builder.HasKey(x => x.Id);


    }
}
