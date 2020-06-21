using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium_s16536.Models;

namespace Kolokwium_s16536.Services
{
    public class EfMusiciansDbService : IMusiciansDbService
    {

        private readonly MusiciansDbContext _context;

        public EfMusiciansDbService(MusiciansDbContext context)
        {
            _context = context;
        }

        public object GetMusician(int id)
        {
            return _context.Musician.Find(id);
        }
    }
}
