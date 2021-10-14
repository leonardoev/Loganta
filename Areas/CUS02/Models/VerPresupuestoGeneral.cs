using loganta.Areas.CUS02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Models
{
    public class VerPresupuestoGeneral
    {
        public PresupuestoGeneral PresupuestoGeneral { get; set; }
        public List<PresupuestoGeneral> PresupuestoGenerales { get; set; }
        public decimal PresupuestoUsado { get; set; }
        public decimal PresupuestoDisponible { get; set; }
    }
}
