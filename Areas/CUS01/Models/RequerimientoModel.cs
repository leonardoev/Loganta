using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Models
{
    public class RequerimientoModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public RequerimientoModel(Requerimiento requerimiento)
        {
            this.Id = requerimiento.Id;
            this.Descripcion = requerimiento.Descripcion;
            this.Cantidad = requerimiento.Cantidad;
            this.Precio = requerimiento.Precio;
        }
    }
}
