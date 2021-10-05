using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Aria:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public Budget Budget { get; set; }
    }
}
