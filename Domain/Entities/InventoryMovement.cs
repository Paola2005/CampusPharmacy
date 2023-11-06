using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InventoryMovement : BaseEntity
    {
        public int IdResponsible { get; set; }
        public User Persons { get; set; }
        public int IdReceiver { get; set; }
        public int IdInventoryMovementType { get; set; }
        public InventoryMovementType InventoriesMovementsTypes { get; set; }
        public DateOnly MovementDate { get; set; }
        public DateOnly ExpirationDate { get; set; }

        public ICollection<InventoryMovementDetail> InventoryMovementDetails { get; set; }
    }
    
}
