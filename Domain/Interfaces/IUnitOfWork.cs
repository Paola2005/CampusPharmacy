using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRol Roles { get; }
        IUser Users { get; }
        IBrand Brands { get; }
        ICity Cities { get; }
        IContactType ContactsTypes { get; }
        ICountry Countries { get; }
        IDocumentType DocumentsTypes { get; }
        IInventory Inventories { get; }
        IInventoryMovement InventoriesMovements { get; }
        IInventoryMovementDetail InventoriesMovementsDetails { get; }
        IInventoryMovementType InventoriesMovementsTypes { get; }
        IPaymentMethod PaymentsMethods { get; }
        IPersonContact PersonsContacts { get; }
        IPresentation Presentations { get; }
        IProduct Products { get; }
        IState States { get; }
        ITypePerson TypesPersons { get; }
        IUbicationPerson UbicationsPersons { get; }
        

        Task<int> SaveAsync();
    }
}
