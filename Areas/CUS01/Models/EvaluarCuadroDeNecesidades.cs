﻿using loganta.Data.Entities;
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
        public int AreaId{ get; set; }
        public RequerimientoModel RequerimientoModel { get; set; }
        public List<RequerimientoModel> RequerimientoModels { get; set; }
    }
}
