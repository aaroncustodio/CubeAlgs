using CubeAlgs.Data.Infrastructure;
using System;
using System.Collections.Generic;

namespace CubeAlgs.Data.Models
{
    public class Group : BaseEntity
    {
        public Guid? SetId { get; set; }
        public Set Set { get; set; }

        public string Name { get; set; }
        public ICollection<Case> Cases { get; set; }
    }
}
