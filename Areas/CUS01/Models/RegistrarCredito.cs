using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Models
{
    public class RegistrarCredito
    {
        public int ProyectoId { get; set; }
        public decimal CreditoProyecto { get; set; }
        public int RequerimientoId { get; set; }
        public decimal CreditoRequerimiento { get; set; }
    }
}
