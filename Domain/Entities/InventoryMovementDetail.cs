using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InventoryMovementDetail : BaseEntity
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public int IdInventoriesMovements { get; set; }
        public InventoryMovement InventoriesMovements { get; set; }
        public int IdInventories { get; set; }
        public Inventory Inventories { get; set; }
    }
}
