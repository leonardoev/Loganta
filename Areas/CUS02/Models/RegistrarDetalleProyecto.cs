using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Models
{
    public class RegistrarDetalleProyecto
    {
        public List<Requerimiento> Requerimientos { get; set; }
        public Requerimiento Requerimiento { get; set; }
        public CuadroDeNecesidades CuadroDeNecesidades { get; set; }
        public decimal PresupuestoSolicitado { get; set; }
    }
}
