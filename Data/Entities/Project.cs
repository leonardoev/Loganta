using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Project: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
        public IEnumerable<Requirement> Requirements{ get; set; }
        public int AriaId { get; set; }
        public Aria Aria { get; set; }
    }
}
