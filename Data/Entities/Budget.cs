using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Budget:BaseEntity
    {
        public int Id{ get; set; }
        public decimal Amount { get; set; }
        public int AriaId { get; set; }
        public Aria Aria { get; set; }
    }
}
