using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;
using Microsoft.AspNetCore.Authorization;

namespace comestic_csharp.Controllers
{
    [Authorize(Roles ="admin")]
    [Area("admin")]
    [Route("admin/category")]
    public class CategoryAController : Controller
    {
        private readonly ShopContext _context;

        public CategoryAController(ShopContext context)
        {
            _context = context;
        }

        // GET: Category
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var shopContext = _context.Categories.Include(c => c.AddedByNavigation).Include(c => c.Parent);
            return View(await shopContext.ToListAsync());
        }

        // GET: Category/Details/5
           [Route("details")]
        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.AddedByNavigation)
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Category/Create
         [Route("create")]// GE
        public IActionResult Create()
        {
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Fullname");
            ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug");
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("Id,Title,Slug,Summary,Photo,IsParent,ParentId,AddedBy,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Fullname", category.AddedBy);
            ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug", category.ParentId);
            return View(category);
        }

        // GET: Category/Edit/5
           [Route("edit")]
        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Fullname", category.AddedBy);
            ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug", category.ParentId);
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ulong id, [Bind("Id,Title,Slug,Summary,Photo,IsParent,ParentId,AddedBy,Status")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            ViewData["AddedBy"] = new SelectList(_context.Users, "Id", "Fullname", category.AddedBy);
            ViewData["ParentId"] = new SelectList(_context.Categories, "Id", "Slug", category.ParentId);
            return View(category);
        }

        // GET: Category/Delete/5
           [Route("delete")]
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.AddedByNavigation)
                .Include(c => c.Parent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(ulong id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}