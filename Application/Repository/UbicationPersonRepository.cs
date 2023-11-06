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
    public class UbicationPersonRepository : GenericRepository<UbicationPerson>, IUbicationPerson
    {
        private readonly JwtDbContext _context;

        public UbicationPersonRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
