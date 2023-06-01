using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MotobikeStore.Data;
using MotobikeStore.Models;

namespace MotobikeStore.Controllers
{
    public class HangXesController : Controller
    {
        private readonly MotobikeStoreContext _context;

        public HangXesController(MotobikeStoreContext context)
        {
            _context = context;
        }

        // GET: HangXes
        public async Task<IActionResult> Index()
        {
              return _context.HangXe != null ? 
                          View(await _context.HangXe.ToListAsync()) :
                          Problem("Entity set 'MotobikeStoreContext.HangXe'  is null.");
        }

        // GET: HangXes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HangXe == null)
            {
                return NotFound();
            }

            var hangXe = await _context.HangXe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hangXe == null)
            {
                return NotFound();
            }

            return View(hangXe);
        }

        // GET: HangXes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HangXes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,hangxe")] HangXe hangXe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hangXe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hangXe);
        }

        // GET: HangXes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HangXe == null)
            {
                return NotFound();
            }

            var hangXe = await _context.HangXe.FindAsync(id);
            if (hangXe == null)
            {
                return NotFound();
            }
            return View(hangXe);
        }

        // POST: HangXes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,hangxe")] HangXe hangXe)
        {
            if (id != hangXe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hangXe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangXeExists(hangXe.Id))
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
            return View(hangXe);
        }

        // GET: HangXes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HangXe == null)
            {
                return NotFound();
            }

            var hangXe = await _context.HangXe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hangXe == null)
            {
                return NotFound();
            }

            return View(hangXe);
        }

        // POST: HangXes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HangXe == null)
            {
                return Problem("Entity set 'MotobikeStoreContext.HangXe'  is null.");
            }
            var hangXe = await _context.HangXe.FindAsync(id);
            if (hangXe != null)
            {
                _context.HangXe.Remove(hangXe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangXeExists(int id)
        {
          return (_context.HangXe?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
