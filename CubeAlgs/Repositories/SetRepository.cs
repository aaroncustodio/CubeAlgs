using CubeAlgs.Data;
using CubeAlgs.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgs.Repositories
{
    public class SetRepository : ISetRepository
    {
        CubeAlgsDbContext _context = new CubeAlgsDbContext();

        public Task<List<Set>> GetSets()
        {
            var sets = _context.Sets.ToListAsync();
            return sets;
        }

        public Task<Set> GetSetById(Guid id)
        {
            var query = _context.Sets.AsQueryable();
            var set = query.FirstOrDefaultAsync(x => x.Id == id);

            return set;
        }
    }
}
