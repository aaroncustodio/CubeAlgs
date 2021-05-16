using CubeAlgs.Data.Infrastructure;
using System;
using System.Collections.Generic;

namespace CubeAlgs.Data.Models
{
    public class Algorithm : BaseEntity
    {
        public Guid CaseId { get; set; }
        public Case Case { get; set; }

        public ICollection<string> Moves { get; set; }
    }
}
