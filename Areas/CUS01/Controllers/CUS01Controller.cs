using loganta.Areas.CUS01.Models;
using loganta.Data;
using loganta.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.CUS01.Controllers
{
    [Area("CUS01")]
    public class CUS01Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CUS01Controller(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult RegistrarPresupuesto()
        {
            ViewData["AreasUsuarias"] = new SelectList(_context.AreaUsuariasT, "Id", "Nombre");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarPresupuesto(RegistrarPresupuesto registrarPresupuesto)
        {
            var areaUsuaria = _context.AreaUsuariasT.Find(registrarPresupuesto.Id);
            areaUsuaria.Presupuesto = registrarPresupuesto.Presupuesto;
            _context.Update(areaUsuaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RegistrarPresupuesto));
        }
        public IActionResult RegistrarCredito()
        {
            ViewData["Proyectos"] = new SelectList(_context.ProyectosT, "Id", "CodProyecto");
            ViewData["Requerimientos"] = new SelectList(_context.RequerimientosT, "Id", "CodRequerimiento");
            return View();
        }
        public async Task<IActionResult> RegistrarCreditoProyecto(RegistrarCredito registrarCredito)
        {
            var proyecto = _context.ProyectosT.Find(registrarCredito.ProyectoId);
            proyecto.MontoTotal = registrarCredito.CreditoProyecto;
            _context.Update(proyecto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RegistrarCredito));
        }
        public async Task<IActionResult> RegistrarCreditoRequerimiento(RegistrarCredito registrarCredito)
        {
            var requerimiento = _context.RequerimientosT.Find(registrarCredito.RequerimientoId);
            requerimiento.Total = registrarCredito.CreditoRequerimiento;
            _context.Update(requerimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RegistrarCredito));
        }
        public async Task<IActionResult> EvaluarCuadroDeNecesidades()
        {
            var applicationDbContext = _context.RequerimientosT;
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
