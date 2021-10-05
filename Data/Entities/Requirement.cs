using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Requirement: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Credit{ get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
