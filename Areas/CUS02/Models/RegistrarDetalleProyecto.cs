using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Models
{
    public class RegistrarDetalleProyecto
    {
        public int AreaUsuariaId { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionProyecto { get; set; }
        public Requerimiento Requerimiento { get; set; }
        public List<Requerimiento> Requerimientos { get; set; }
        public decimal PresupuestoSolicitado { get; set; }
    }
}
