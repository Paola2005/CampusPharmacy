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
    public class PersonContactRepository : GenericRepository<PersonContact>, IPersonContact
    {
        private readonly JwtDbContext _context;

        public PersonContactRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
