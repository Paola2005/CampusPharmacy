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
    public class ProductRepository : GenericRepository<Product>, IProduct
    {
        private readonly JwtDbContext _context;

        public ProductRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
