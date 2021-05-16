using CubeAlgs.Data.Infrastructure;
using System.Collections.Generic;

namespace CubeAlgs.Data.Models
{
    public class Set : BaseEntity
    {
        public string Name { get; set; }
        public bool IsCustom { get; set; } = false;

        public ICollection<Group> Groups { get; set; }
        public ICollection<Case> Cases { get; set; }
    }
}
