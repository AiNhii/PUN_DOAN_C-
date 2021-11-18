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
    public class ProductreviewsController : Controller
    {
        private readonly PunContext _context;

        public ProductreviewsController(PunContext context)
        {
            _context = context;
        }

        // GET: Productreviews
        public async Task<IActionResult> Index()
        {
            var punContext = _context.Productreviews.Include(p => p.Product).Include(p => p.User);
            return View(await punContext.ToListAsync());
        }

        // GET: Productreviews/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productreview = await _context.Productreviews
                .Include(p => p.Product)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productreview == null)
            {
                return NotFound();
            }

            return View(productreview);
        }

        // GET: Productreviews/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname");
            return View();
        }

        // POST: Productreviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ProductId,Rating,Review,Status")] Productreview productreview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productreview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productreview.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", productreview.UserId);
            return View(productreview);
        }

        // GET: Productreviews/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productreview = await _context.Productreviews.FindAsync(id);
            if (productreview == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productreview.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", productreview.UserId);
            return View(productreview);
        }

        // POST: Productreviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,UserId,ProductId,Rating,Review,Status")] Productreview productreview)
        {
            if (id != productreview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productreview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductreviewExists(productreview.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Condition", productreview.ProductId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", productreview.UserId);
            return View(productreview);
        }

        // GET: Productreviews/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productreview = await _context.Productreviews
                .Include(p => p.Product)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productreview == null)
            {
                return NotFound();
            }

            return View(productreview);
        }

        // POST: Productreviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productreview = await _context.Productreviews.FindAsync(id);
            _context.Productreviews.Remove(productreview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductreviewExists(long id)
        {
            return _context.Productreviews.Any(e => e.Id == id);
        }
    }
}
