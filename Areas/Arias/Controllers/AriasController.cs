using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using loganta.Data;
using loganta.Data.Entities;

namespace loganta.Areas.Arias.Controllers
{
    [Area("Arias")]
    public class AriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Arias/Arias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Arias.ToListAsync());
        }

        // GET: Arias/Arias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aria = await _context.Arias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aria == null)
            {
                return NotFound();
            }

            return View(aria);
        }

        // GET: Arias/Arias/Create
        public IActionResult Create()
        {
            ViewData["AriaId"] = new SelectList(_context.Arias, "Id", "Id");
            return View();
        }

        // POST: Arias/Arias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CreatedOn,UpdatedOn")] Aria aria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aria);
        }

        // GET: Arias/Arias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aria = await _context.Arias.FindAsync(id);
            if (aria == null)
            {
                return NotFound();
            }
            return View(aria);
        }

        // POST: Arias/Arias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CreatedOn,UpdatedOn")] Aria aria)
        {
            if (id != aria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AriaExists(aria.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aria);
        }

        // GET: Arias/Arias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aria = await _context.Arias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aria == null)
            {
                return NotFound();
            }

            return View(aria);
        }

        // POST: Arias/Arias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aria = await _context.Arias.FindAsync(id);
            _context.Arias.Remove(aria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AriaExists(int id)
        {
            return _context.Arias.Any(e => e.Id == id);
        }
    }
}
