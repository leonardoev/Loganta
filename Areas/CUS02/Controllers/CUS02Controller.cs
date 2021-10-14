using loganta.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS02.Controllers
{
    [Area("CUS02")]
    public class CUS02Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CUS02Controller(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> VerPresupuestoGeneral()
        {
            var presupuestos =  _context.PresupuestosT.Include(p => p.Proyecto);
            return View(await presupuestos.ToListAsync());
        }
        public async Task<IActionResult> RegistrarDetalleProyecto()
        {
            var proyectos = _context.ProyectosT;
            return View(await proyectos.ToListAsync());
        }
        public async Task<IActionResult> RegistrarCuadroDeNecesidades()
        {
            var requerimientos = _context.RequerimientosT;
            return View(await requerimientos.ToListAsync());
        }
        public IActionResult RegistrarCostoRequerimiento()
        {
            return View();
        }

    }
}
