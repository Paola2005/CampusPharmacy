using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class InventoryMovementDetailConfiguration : IEntityTypeConfiguration<InventoryMovementDetail>
    {
        public void Configure(EntityTypeBuilder<InventoryMovementDetail> builder)
        {
            builder.ToTable("InventoryMovementDetail");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Amount);
        builder.Property(o=>o.Price);


        builder.HasOne(p=>p.InventoriesMovements)
        .WithMany(p=>p.InventoryMovementDetails)
        .HasForeignKey(p=>p.IdInventoriesMovements);

        builder.HasOne(p=>p.Inventories)
        .WithMany(p=>p.InventoriesMovementsDetails)
        .HasForeignKey(p=>p.IdInventories);
        }
    }
}
