using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Data.Entities
{
    public class AreaUsuaria
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
        public string Descripcion { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Proyecto> Proyectos { get; set; }
    }
}
