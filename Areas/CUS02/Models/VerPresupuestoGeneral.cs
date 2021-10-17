using loganta.Areas.CUS02.Data;
using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Models
{
    public class VerPresupuestoGeneral
    {
        public Presupuesto Presupuesto { get; set; }
        public List<Presupuesto> Presupuestos { get; set; }
        public List<Proyecto> Proyectos { get; set; }
        public decimal PresupuestoUsado { get; set; }
        public decimal PresupuestoDisponible { get; set; }

    }
}
