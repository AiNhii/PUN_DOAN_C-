using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;
using comestic_csharp.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace comestic_csharp.Controllers
{
    [Authorize(Roles ="admin")]
    [Area("admin")]
    [Route("admin/coupon")]
    public class CouponController : Controller
    {
        private readonly ShopDbContext _context;

        public CouponController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: Coupon
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Coupons.ToListAsync());
        }

        // GET: Coupon/Details/5
        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coupon = await _context.Coupons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }

            return View(coupon);
        }

        // GET: Coupon/Create
         [Route("create")]// 
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coupon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
         [Route("create")]// 
        public async Task<IActionResult> Create([Bind("Id,Code,Type,Value,Status,IsVoucher,Quantity,StartedAt,EndedAt")] Coupon coupon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coupon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupon);
        }

        // GET: Coupon/Edit/5
         [Route("edit")]

        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coupon = await _context.Coupons.FindAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        // POST: Coupon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
         [Route("edit")]

        public async Task<IActionResult> Edit(ulong id, [Bind("Id,Code,Type,Value,Status,IsVoucher,Quantity,StartedAt,EndedAt")] Coupon coupon)
        {
            if (id != coupon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coupon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CouponExists(coupon.Id))
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
            return View(coupon);
        }

        // GET: Coupon/Delete/5
         [Route("delete")]
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coupon = await _context.Coupons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }

            return View(coupon);
        }

        // POST: Coupon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
         [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var coupon = await _context.Coupons.FindAsync(id);
            _context.Coupons.Remove(coupon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CouponExists(ulong id)
        {
            return _context.Coupons.Any(e => e.Id == id);
        }
    }
}
