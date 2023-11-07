using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPerson
    {
        private readonly PharmacyContext _context;

        public PersonRepository(PharmacyContext context) : base(context)
        {
            _context = context;
        }
    }
}