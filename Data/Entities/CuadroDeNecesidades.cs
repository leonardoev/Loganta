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
        public string Responsable { get; set; }
        public string AreaUsuaria { get; set; }
        public string Tipo { get; set; }
        public int Codigo { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

        public List<Requerimiento> Requerimientos{ get; set; }
    }
}
