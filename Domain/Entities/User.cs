using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
    public ICollection<UserRol> UsersRols { get; set; }

        public DateOnly RegistrationDate { get; set; }
        public int IdDocument { get; set; }
        public DocumentType DocumentsTypes { get; set; }
        public int IdTypePerson { get; set; }
        public TypePerson TypesPersons { get; set; }

        public ICollection<PersonContact> PersonsContacts { get; set; }
        public ICollection<InventoryMovement> InventoriesMovements { get; set; }
        public ICollection<UbicationPerson> UbicationsPersons { get; set; }
    }
}
