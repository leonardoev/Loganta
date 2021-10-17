using loganta.Areas.CUS02.Models;
using loganta.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            VerPresupuestoGeneral verPresupuestoGeneral = new VerPresupuestoGeneral();

            var presupuestos = await _context.PresupuestosT.Include(p => p.Proyecto).Include(a => a.Proyecto.AreaUsuaria).ToListAsync();
            var proyectos = await _context.ProyectosT.ToListAsync();


            verPresupuestoGeneral.Presupuestos = presupuestos;
            verPresupuestoGeneral.Proyectos = proyectos;

            return View(verPresupuestoGeneral);
        }
        public async Task<IActionResult> RegistrarDetalleProyecto()
        {
            ViewData["AreasUsuarias"] = new SelectList(_context.AreaUsuariasT, "Id", "Nombre");
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
