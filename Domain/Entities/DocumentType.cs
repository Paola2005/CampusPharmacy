using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DocumentType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Persons { get; set; }
    }
}
