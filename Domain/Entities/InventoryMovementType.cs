using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InventoryMovementType : BaseEntity
    {
         public string Name { get; set; }
        public ICollection<InventoryMovement> InventoriesMovements { get; set; }
    }
}
