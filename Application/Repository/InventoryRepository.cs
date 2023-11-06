using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventory
    {
        private readonly JwtDbContext _context;

        public InventoryRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
