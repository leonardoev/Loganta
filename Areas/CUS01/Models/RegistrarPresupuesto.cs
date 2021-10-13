using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Models
{
    public class RegistrarPresupuesto
    {
        [Display(Name = "Selecciona Área:")]
        public int Id { get; set; }
        [Display(Name = "Presupuesto:")]
        public decimal Presupuesto { get; set; }
    }
}
