using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inventory : BaseEntity
    {
        public string Name { get; set; }
        public int IdProduct { get; set; }
        public Product Products { get; set; }
        public int IdPresentation { get; set; }
        public Presentation Presentations { get; set; }
        public double Price { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }
        public int Stock { get; set; }
        public ICollection<InventoryMovementDetail> InventoriesMovementsDetails { get; set; }
    }
}
