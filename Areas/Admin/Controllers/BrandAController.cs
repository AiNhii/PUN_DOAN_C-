using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;
using Microsoft.AspNetCore.Authorization;
using comestic_csharp.Areas.Identity.Data;

namespace comestic_csharp.Controllers
{
    [Authorize(Roles ="admin")]
    [Area("admin")]
    [Route("admin/brand")]
    public class BrandAController : Controller
    {
        private readonly ShopDbContext _context;

        public BrandAController(ShopDbContext context)
        {
            _context = context;
        }

        [Route("index")]// GET: Brand
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }

        // GET: Brand/Details/5
        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // GET: Brand/Create
        [Route("create")]// GE
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [Route("create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Slug,Status")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }

        // GET: Brand/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            ViewData["Status"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "active", Value = "active"},
                    new SelectListItem { Text = "inactive", Value = "inactive"},
                }, "Value" , "Text",brand.Status

            );
            return View(brand);
            
        }

        // POST: Brand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(ulong id, [Bind("Id,Title,Slug,Status")] Brand brand)
        {
            if (id != brand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(brand.Id))
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
            ViewData["Status"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "active", Value = "active"},
                    new SelectListItem { Text = "inactive", Value = "inactive"},
                }, "Value" , "Text",brand.Status

            );
            return View(brand);
        }

        // GET: Brand/Delete/5
         [Route("delete")]
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // POST: Brand/Delete/5
        [Route("delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var brand = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandExists(ulong id)
        {
            return _context.Brands.Any(e => e.Id == id);
        }
    }
}