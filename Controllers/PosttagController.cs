using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_db.Models;

namespace Web_db.Controllers
{
    public class PosttagController : Controller
    {
        private readonly PunContext _context;

        public PosttagController(PunContext context)
        {
            _context = context;
        }

        // GET: Posttag
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posttags.ToListAsync());
        }

        // GET: Posttag/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttag = await _context.Posttags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posttag == null)
            {
                return NotFound();
            }

            return View(posttag);
        }

        // GET: Posttag/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Posttag/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Slug,Status")] Posttag posttag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(posttag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(posttag);
        }

        // GET: Posttag/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttag = await _context.Posttags.FindAsync(id);
            if (posttag == null)
            {
                return NotFound();
            }
            return View(posttag);
        }

        // POST: Posttag/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Title,Slug,Status")] Posttag posttag)
        {
            if (id != posttag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posttag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PosttagExists(posttag.Id))
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
            return View(posttag);
        }

        // GET: Posttag/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posttag = await _context.Posttags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posttag == null)
            {
                return NotFound();
            }

            return View(posttag);
        }

        // POST: Posttag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var posttag = await _context.Posttags.FindAsync(id);
            _context.Posttags.Remove(posttag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PosttagExists(long id)
        {
            return _context.Posttags.Any(e => e.Id == id);
        }
    }
}
