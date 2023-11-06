using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository
{
    public class RolRepository:GenericRepository<Rol>,IRol
    {
        private readonly JwtDbContext _context;

    public RolRepository(JwtDbContext context) : base(context)
    {
        _context = context;
    }
    }
    
}