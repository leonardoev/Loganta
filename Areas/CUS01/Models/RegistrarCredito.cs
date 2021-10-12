using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Models
{
    public class RegistrarCredito
    {
        public Proyecto Proyecto { get; set; }
        public Requerimiento Requerimiento { get; set; }
    }
}
