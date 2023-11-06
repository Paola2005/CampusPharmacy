using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class InventoryMovementTypeConfiguration : IEntityTypeConfiguration<InventoryMovementType>
    {
        public void Configure(EntityTypeBuilder<InventoryMovementType> builder)
        {
            builder.ToTable("InventoryMovementType");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Name)
        .HasMaxLength(50);
        }
    }
}
