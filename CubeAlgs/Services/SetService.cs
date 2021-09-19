using CubeAlgs.Data.Models;
using CubeAlgs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgs.Services
{
    public class SetService : ISetService
    {
        private readonly ISetRepository _setRepo;

        public SetService(ISetRepository setRepo)
        {
            _setRepo = setRepo;    
        }

        public Task<List<Set>> GetSets()
        {
            var sets = _setRepo.GetSets();
            return sets;
        }

        public Task<Set> GetSetById(Guid id)
        {
            var set = _setRepo.GetSetById(id);
            return set;
        }
    }
}
