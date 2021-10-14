using loganta.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Models
{
    public class EvaluarCuadroDeNecesidades
    {
        [Display(Name = "Selecciona Área:")]
        public int AreaUsuariaId{ get; set; }
        public Requerimiento Requerimiento { get; set; }
        public List<Requerimiento> Requerimientos { get; set; }
    }
}
