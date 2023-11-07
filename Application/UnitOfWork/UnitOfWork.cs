using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly JwtDbContext _context;
    private IRol _roles;
    private IBrand _brand;
    private ICity _city;
    private IContactType _contactype;
    private ICountry _country;
    private IDocumentType _documentype;
    private IInventory _inventory;
    private IInventoryMovement _inventorymovement;
    private IInventoryMovementDetail _inventorymovementdetail;
    private IInventoryMovementType _inventorymovementtype;
    private IPaymentMethod _paymentmethod;
    private IPersonContact _personcontact;
    private IPresentation _presentation;
    private IProduct _product;
    private IState _state;
    private ITypePerson _typeperson;
    private IUbicationPerson _ubicationperson;
    private IUser _users;

    public IRol Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }

    public IUser Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public IBrand Brands
    {
        get
        {
            if (_brand == null)
            {
                _brand = new BrandRepository(_context);
            }
            return _brand;
        }
    }

    public ICity Cities
    {
        get
        {
            if (_city == null)
            {
                _city = new CityRepository(_context);
            }
            return _city;
        }
    }

    public IContactType ContactsTypes
    {
        get
        {
            if (_contactype == null)
            {
                _contactype = new ContactTypeRepository(_context);
            }
            return _contactype;
        }
    }

    public ICountry Countries
    {
        get
        {
            if (_country == null)
            {
                _country = new CountryRepository(_context);
            }
            return _country;
        }
    }

    public IDocumentType DocumentsTypes
    {
        get
        {
            if (_documentype == null)
            {
                _documentype = new DocumentTypeRepository(_context);
            }
            return _documentype;
        }
    }

    public IInventory Inventories
    {
        get
        {
            if (_inventory == null)
            {
                _inventory = new InventoryRepository(_context);
            }
            return _inventory;
        }
    }

    public IInventoryMovement InventoriesMovements
    {
        get
        {
            if (_inventorymovement == null)
            {
                _inventorymovement = new InventoryMovementRepository(_context);
            }
            return _inventorymovement;
        }
    }

    public IInventoryMovementDetail InventoriesMovementsDetails
    {
        get
        {
            if (_inventorymovementdetail == null)
            {
                _inventorymovementdetail = new InventoryMovementDetailRepository(_context);
            }
            return _inventorymovementdetail;
        }
    }

    public IInventoryMovementType InventoriesMovementsTypes
    {
        get
        {
            if (_inventorymovementtype == null)
            {
                _inventorymovementtype = new InventoryMovementTypeRepository(_context);
            }
            return _inventorymovementtype;
        }
    }

    public IPaymentMethod PaymentsMethods
    {
        get
        {
            if (_paymentmethod == null)
            {
                _paymentmethod = new PaymentMethodRepository(_context);
            }
            return _paymentmethod;
        }
    }

    public IPersonContact PersonsContacts
    {
        get
        {
            if (_personcontact == null)
            {
                _personcontact = new PersonContactRepository(_context);
            }
            return _personcontact;
        }
    }

    public IPresentation Presentations
    {
        get
        {
            if (_presentation == null)
            {
                _presentation = new PresentationRepository(_context);
            }
            return _presentation;
        }
    }

    public IProduct Products
    {
        get
        {
            if (_product == null)
            {
                _product = new ProductRepository(_context);
            }
            return _product;
        }
    }

    public IState States
    {
        get
        {
            if (_state == null)
            {
                _state = new StateRepository(_context);
            }
            return _state;
        }
    }

    public ITypePerson TypesPersons
    {
        get
        {
            if (_typeperson == null)
            {
                _typeperson = new TypePersonRepository(_context);
            }
            return _typeperson;
        }
    }

    public IUbicationPerson UbicationsPersons
    {
        get
        {
            if (_ubicationperson == null)
            {
                _ubicationperson = new UbicationPersonRepository(_context);
            }
            return _ubicationperson;
        }
    }

    public UnitOfWork(JwtDbContext context)
    {
        _context = context;
    }
    


    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
