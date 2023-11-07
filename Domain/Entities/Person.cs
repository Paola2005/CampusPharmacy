using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person:BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public int IdDocument { get; set; }
        public DocumentType DocumentsTypes { get; set; }
        public int IdRolePerson { get; set; }
        public RolePerson RolesPersons { get; set; }
        public int IdTypePerson { get; set; }
        public TypePerson TypesPersons { get; set; }

        public ICollection<PersonContact> PersonsContacts { get; set; }
        public ICollection<InventoryMovement> InventoriesMovements { get; set; }
        public ICollection<UbicationPerson> UbicationsPersons { get; set; }
    }
}