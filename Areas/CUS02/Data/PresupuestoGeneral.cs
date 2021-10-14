using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Data
{
    public class PresupuestoGeneral
    {
        public int Id { get; set; }
        public string Proyecto { get; set; }
        public string Area { get; set; }
        public decimal Presupuesto { get; set; }

        public PresupuestoGeneral(Presupuesto presupuesto, AreaUsuaria areaUsuaria)
        {
            this.Id = presupuesto.Id;
            this.Proyecto = presupuesto.Proyecto.CodProyecto;
            this.Area = areaUsuaria.Nombre;
            this.Presupuesto = presupuesto.Monto;
        }
    }
}
