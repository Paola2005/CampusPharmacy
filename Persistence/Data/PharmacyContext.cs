using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands {get;set;}
        public DbSet<City> Cities {get;set;}
        public DbSet<ContactType> ContactTypes {get;set;}
        public DbSet<Country> Countries {get;set;}
        public DbSet<DocumentType> DocumentTypes {get;set;}
        public DbSet<Inventory> Inventories {get;set;}
        public DbSet<InventoryMovement> InventoryMovements {get;set;}
        public DbSet<InventoryMovementDetail> InventoryMovementDetails {get;set;}
        public DbSet<InventoryMovementType> InventoryMovementTypes {get;set;}
        public DbSet<PaymentMethod> PaymentMethods {get;set;}
        public DbSet<Person> Persons {get;set;}
        public DbSet<PersonContact> PersonContacts {get;set;}
        public DbSet<Presentation> Presentations {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<Receipt> Receipts {get;set;}
        public DbSet<RolePerson> RolePeople {get;set;}
        public DbSet<State> States {get;set;}
        public DbSet<TypePerson> TypePeople {get;set;}
        public DbSet<UbicationPerson> UbicationPeople {get;set;}

        
    }
}