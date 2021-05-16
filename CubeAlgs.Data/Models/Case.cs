using CubeAlgs.Data.Infrastructure;
using System;
using System.Collections.Generic;

namespace CubeAlgs.Data.Models
{
    public class Case : BaseEntity
    {
        public Guid SetId { get; set; }
        public Set Set { get; set; }
        public Guid? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<string> Names { get; set; }
        public ICollection<Algorithm> Algorithms { get; set; }
    }
}
