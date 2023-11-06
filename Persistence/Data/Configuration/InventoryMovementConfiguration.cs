using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class InventoryMovementConfiguration : IEntityTypeConfiguration<InventoryMovement>
    {
        public void Configure(EntityTypeBuilder<InventoryMovement> builder)
        {
            builder.ToTable("InventoryMovement");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.MovementDate);
        builder.Property(p=>p.ExpirationDate);
        
        builder.HasOne(p=>p.InventoriesMovementsTypes)
        .WithMany(p=>p.InventoriesMovements)
        .HasForeignKey(p=>p.IdInventoryMovementType);

        builder.HasOne(p=>p.Persons)
        .WithMany(p=>p.InventoriesMovements)
        .HasForeignKey(p=>p.IdResponsible);
        }
    }
}
