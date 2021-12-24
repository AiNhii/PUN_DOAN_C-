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
    [Route("admin/order")]
    public class OrderController : Controller
    {
        private readonly ShopDbContext _context;

        public OrderController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: Order
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Order/Details/5
        // public async Task<IActionResult> Details(ulong? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var order = await _context.Orders
        //         .Include(o => o.Coupon)
        //         .Include(o => o.Shipping)
        //         .Include(o => o.User)
        //         .FirstOrDefaultAsync(m => m.Id == id);
        //     if (order == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(order);
        // }

        // GET: Order/Create
        [Route("create")]// 
        public IActionResult Create()
        {
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code");
            ViewData["ShippingId"] = new SelectList(_context.Shippings, "Id", "Status");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname");
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]// 
        public async Task<IActionResult> Create([Bind("Id,OrderNumber,ProductId,UserId,SubTotal,ShippingId,CouponId,TotalAmount,Quantity,PaymentMethod,PaymentStatus,Status,FirstName,LastName,Email,Phone,Address")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", order.CouponId);
            ViewData["ShippingId"] = new SelectList(_context.Shippings, "Id", "Status", order.ShippingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", order.UserId);
            return View(order);
        }

        // GET: Order/Edit/5
         [Route("edit")]
        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", order.CouponId);
            ViewData["ShippingId"] = new SelectList(_context.Shippings, "Id", "Status", order.ShippingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", order.UserId);
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
         [Route("edit")]
        public async Task<IActionResult> Edit(ulong id, [Bind("Id,OrderNumber,ProductId,UserId,SubTotal,ShippingId,CouponId,TotalAmount,Quantity,PaymentMethod,PaymentStatus,Status,FirstName,LastName,Email,Phone,Address")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", order.CouponId);
            ViewData["ShippingId"] = new SelectList(_context.Shippings, "Id", "Status", order.ShippingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Fullname", order.UserId);
            return View(order);
        }

        // GET: Order/Delete/5
         [Route("delete")]
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Coupon)
                .Include(o => o.Shipping)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
         [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(ulong id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }

        public IActionResult Details(ulong? id)
        {
            var orderdetails = _context.Orderdetail.Where(p => p.OrderId == id);
            var order = _context.Orders.First(p => p.Id == id);
            ViewBag.Order = order;
            return View(orderdetails);
        }
    }
}