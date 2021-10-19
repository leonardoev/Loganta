using loganta.Areas.CUS02.Models;
using loganta.Data;
using loganta.Data.Entities;
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
        public async Task<IActionResult> RegistrarDetalleProyecto(RegistrarDetalleProyecto registrarDetalleProyecto)
        {
            var requerimientos = await _context.RequerimientosT
                .Where(r => r.CuadroDeNecesidades.Fecha == registrarDetalleProyecto.Fecha 
                && r.CuadroDeNecesidades.Proyecto.AreaUsuariaId == registrarDetalleProyecto.AreaUsuariaId
                || r.CuadroDeNecesidades.Proyecto.Descripcion == registrarDetalleProyecto.DescripcionProyecto)
                .ToListAsync();
            ViewData["AreasUsuarias"] = new SelectList(_context.AreaUsuariasT, "Id", "Nombre");

            registrarDetalleProyecto.Requerimientos = requerimientos;
            return View(registrarDetalleProyecto);
        }
        public IActionResult AnadirRequerimiento()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AnadirRequerimiento(int id, AnadirRequerimiento anadirRequerimiento)
        {
            anadirRequerimiento.Requerimiento.CuadroDeNecesidadesId = id;
            _context.RequerimientosT.Add(anadirRequerimiento.Requerimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RegistrarDetalleProyecto));
        }
        public IActionResult RegistrarCostoRequerimiento()
        {
            return View();
        }

    }
}
