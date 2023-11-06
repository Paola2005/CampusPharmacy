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
    public class InventoryMovementTypeRepository : GenericRepository<InventoryMovementType>, IInventoryMovementType
    {
        private readonly JwtDbContext context;

        public InventoryMovementTypeRepository(JwtDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
