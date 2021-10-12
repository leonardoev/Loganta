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
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegistrarPresupuesto(AreaUsuaria areaUsuaria)
        {
            _context.Add(areaUsuaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RegistrarPresupuesto));
        }
        public IActionResult RegistrarCredito()
        {
            return View();
        }
        public async Task<IActionResult> EvaluarCuadroDeNecesidades()
        {
            var applicationDbContext = _context.RequerimientosT;
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
