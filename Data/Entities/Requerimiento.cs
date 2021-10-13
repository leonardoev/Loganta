using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Requerimiento
    {
        public int Id { get; set; }
        public string CodRequerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public int Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Mes { get; set; }
        public int CuadroDeNecesidadesId { get; set; }
        public CuadroDeNecesidades CuadroDeNecesidades { get; set; }
    }
}
