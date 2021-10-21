using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class CuadroDeNecesidades
    {
        public int Id{ get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal TotalGeneral { get; set; }
        public List<Proyecto> Proyectos { get; set; }
        public List<Requerimiento> Requerimientos{ get; set; }
    }
}
