using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int IdState { get; set; }
        public State States { get; set; }
        public ICollection<UbicationPerson> UbicationPersons { get; set; }
    }
}
