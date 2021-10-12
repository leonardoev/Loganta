using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public int Periodo { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

    }
}
