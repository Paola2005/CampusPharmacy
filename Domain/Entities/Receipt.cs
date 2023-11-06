using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Receipt:BaseEntity
    {
        public int InitialInvoice { get; set; }
        public int CurrentInvoice { get; set; }
        public string NumberResolution { get; set; }
    }
}