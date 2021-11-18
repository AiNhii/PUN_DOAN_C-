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
    public class ProductattributesController : Controller
    {
        private readonly PunContext _context;

        public ProductattributesController(PunContext context)
        {
            _context = context;
        }

        // GET: Productattributes
        public async Task<IActionResult> Index()
        {
            var punContext = _context.Productattributes.Include(p => p.Product);
            return View(await punContext.ToListAsync());
        }

        // GET: Productattributes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productattribute = await _context.Productattributes
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productattribute == null)
            {
                return NotFound();
            }

            return View(productattribute);
        }

        // GET: Productattributes/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition");
            return View();
        }

        // POST: Productattributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Color,Price,Stock,ProductId")] Productattribute productattribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productattribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productattribute.ProductId);
            return View(productattribute);
        }

        // GET: Productattributes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productattribute = await _context.Productattributes.FindAsync(id);
            if (productattribute == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productattribute.ProductId);
            return View(productattribute);
        }

        // POST: Productattributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Color,Price,Stock,ProductId")] Productattribute productattribute)
        {
            if (id != productattribute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productattribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductattributeExists(productattribute.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productattribute.ProductId);
            return View(productattribute);
        }

        // GET: Productattributes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productattribute = await _context.Productattributes
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productattribute == null)
            {
                return NotFound();
            }

            return View(productattribute);
        }

        // POST: Productattributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productattribute = await _context.Productattributes.FindAsync(id);
            _context.Productattributes.Remove(productattribute);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductattributeExists(long id)
        {
            return _context.Productattributes.Any(e => e.Id == id);
        }
    }
}
