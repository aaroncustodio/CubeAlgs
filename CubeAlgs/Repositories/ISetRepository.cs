using CubeAlgs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgs.Repositories
{
    public interface ISetRepository
    {
        Task<List<Set>> GetSets();
        Task<Set> GetSetById(Guid id);
    }
}
