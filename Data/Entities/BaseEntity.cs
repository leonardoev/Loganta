using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
