using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonContact : BaseEntity
    {
        public int IdPerson { get; set; }
        public User Persons { get; set; }
        public int IdTypeContact { get; set; }
        public ContactType TypeContact { get; set; }
    }
}
