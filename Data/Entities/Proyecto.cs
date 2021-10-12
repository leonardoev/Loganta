using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class Proyecto
    {
        public int Id { get; set; }
        public int CodProyecto { get; set; }
        public string Descripcion { get; set; }
        public string UnidadEjecutora { get; set; }
        public string Sector { get; set; }
        public string Entidad { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoModificado { get; set; }
        public int Duracion { get; set; }
        public int AreaUsuariaId { get; set; }
        public AreaUsuaria AreaUsuaria { get; set; }
        public List<CuadroDeNecesidades> CuadroDeNecesidadess { get; set; }
        public Presupuesto Presupuesto { get; set; }
    }
}
