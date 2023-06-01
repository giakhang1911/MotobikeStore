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
    public class DongXesController : Controller
    {
        private readonly MotobikeStoreContext _context;

        public DongXesController(MotobikeStoreContext context)
        {
            _context = context;
        }

        // GET: DongXes
        public async Task<IActionResult> Index()
        {
              return _context.DongXe != null ? 
                          View(await _context.DongXe.ToListAsync()) :
                          Problem("Entity set 'MotobikeStoreContext.DongXe'  is null.");
        }

        // GET: DongXes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DongXe == null)
            {
                return NotFound();
            }

            var dongXe = await _context.DongXe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dongXe == null)
            {
                return NotFound();
            }

            return View(dongXe);
        }

        // GET: DongXes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DongXes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dongxe")] DongXe dongXe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dongXe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dongXe);
        }

        // GET: DongXes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DongXe == null)
            {
                return NotFound();
            }

            var dongXe = await _context.DongXe.FindAsync(id);
            if (dongXe == null)
            {
                return NotFound();
            }
            return View(dongXe);
        }

        // POST: DongXes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dongxe")] DongXe dongXe)
        {
            if (id != dongXe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dongXe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DongXeExists(dongXe.Id))
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
            return View(dongXe);
        }

        // GET: DongXes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DongXe == null)
            {
                return NotFound();
            }

            var dongXe = await _context.DongXe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dongXe == null)
            {
                return NotFound();
            }

            return View(dongXe);
        }

        // POST: DongXes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DongXe == null)
            {
                return Problem("Entity set 'MotobikeStoreContext.DongXe'  is null.");
            }
            var dongXe = await _context.DongXe.FindAsync(id);
            if (dongXe != null)
            {
                _context.DongXe.Remove(dongXe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DongXeExists(int id)
        {
          return (_context.DongXe?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
