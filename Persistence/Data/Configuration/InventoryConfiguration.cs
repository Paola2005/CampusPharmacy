using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventory");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Name)
        .HasMaxLength(50);

        builder.Property(p=>p.Price);
        builder.Property(p=>p.Stock);
        builder.Property(p=>p.StockMax);
        builder.Property(p=>p.StockMin);

        builder.HasOne(p=>p.Products)
        .WithMany(p=>p.Inventories)
        .HasForeignKey(p=>p.IdProduct);

        builder.HasOne(p=>p.Presentations)
        .WithMany(p=>p.Inventories)
        .HasForeignKey(p=>p.IdPresentation);
        }
    }
}
