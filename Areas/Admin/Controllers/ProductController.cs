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
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private readonly ShopDbContext _context;

        public ProductController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: Product
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var ShopDbContext = _context.Products.Include(p => p.Brand).Include(p => p.Cat).Include(p => p.ChildCat).Include(p => p.Coupon);
            return View(await ShopDbContext.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Cat)
                .Include(p => p.ChildCat)
                .Include(p => p.Coupon)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        [Route("create")]// 
        public IActionResult Create()
        {


            ViewData["Status"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "active", Value = "active"},
                    new SelectListItem { Text = "inactive", Value = "inactive"},
                }, "Value" , "Text"
            );

            ViewData["Condition"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "default", Value = "default"},
                    new SelectListItem { Text = "hot", Value = "hot"},
                    new SelectListItem { Text = "new", Value = "new"},

                }, "Value" , "Text"

            );

            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Slug");
            ViewData["CatId"] = new SelectList(_context.Categories, "Id", "Slug");
            ViewData["ChildCatId"] = new SelectList(_context.Categories, "Id", "Slug");
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Id,Title,Slug,Summary,Description,Photo1,Photo2,Photo3,Photo4,Stock,Condition,Status,Price,CouponId,CatId,ChildCatId,BrandId")] Product product)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(product);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }

        //     ViewData["Status"] = new SelectList(

        //          new List<SelectListItem>
        //         {
        //             new SelectListItem { Text = "active", Value = "active"},
        //             new SelectListItem { Text = "inactive", Value = "inactive"},
        //         }, "Value" , "Text",product.Status

        //     );

        //     ViewData["Condition"] = new SelectList(

        //          new List<SelectListItem>
        //         {
        //             new SelectListItem { Text = "default", Value = "default"},
        //             new SelectListItem { Text = "hot", Value = "hot"},
        //             new SelectListItem { Text = "new", Value = "new"},

        //         }, "Value" , "Text",product.Condition

        //     );



        //     ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Slug", product.BrandId);
        //     ViewData["CatId"] = new SelectList(_context.Categories, "Id", "Slug", product.CatId);
        //     ViewData["ChildCatId"] = new SelectList(_context.Categories, "Id", "Slug", product.ChildCatId);
        //     ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", product.CouponId);
        //     return View(product);
        // }


        public async Task<IActionResult> Create([Bind("Id,Title,Slug,Summary,Description,Photo1,Photo2,Photo3,Photo4,Stock,Condition,Status,Price,CouponId,CatId,ChildCatId,BrandId")] Product product)
        {
            if (ModelState.IsValid)
            {
                if(product.CouponId != 1){
                    var giamGia = _context.Coupons.SingleOrDefault(p => p.Id == product.CouponId);
                    var newPrice = product.Price * ( 1 - giamGia.Value /100);
                    product.Price = newPrice;
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Status"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "active", Value = "active"},
                    new SelectListItem { Text = "inactive", Value = "inactive"},
                }, "Value" , "Text",product.Status

            );

            ViewData["Condition"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "default", Value = "default"},
                    new SelectListItem { Text = "hot", Value = "hot"},
                    new SelectListItem { Text = "new", Value = "new"},

                }, "Value" , "Text",product.Condition

            );



            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Slug", product.BrandId);
            ViewData["CatId"] = new SelectList(_context.Categories, "Id", "Slug", product.CatId);
            ViewData["ChildCatId"] = new SelectList(_context.Categories, "Id", "Slug", product.ChildCatId);
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", product.CouponId);
            return View(product);
        }

        // GET: Product/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["Status"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "active", Value = "active"},
                    new SelectListItem { Text = "inactive", Value = "inactive"},
                }, "Value" , "Text",product.Status

            );

            ViewData["Condition"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "default", Value = "default"},
                    new SelectListItem { Text = "hot", Value = "hot"},
                    new SelectListItem { Text = "new", Value = "new"},

                }, "Value" , "Text",product.Condition

            );

            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Slug", product.BrandId);
            ViewData["CatId"] = new SelectList(_context.Categories, "Id", "Slug", product.CatId);
            ViewData["ChildCatId"] = new SelectList(_context.Categories, "Id", "Slug", product.ChildCatId);
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", product.CouponId);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ulong id, [Bind("Id,Title,Slug,Summary,Description,Photo1,Photo2,Photo3,Photo4,Stock,Condition,Status,Price,CouponId,CatId,ChildCatId,BrandId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(product.CouponId != 1){
                        var giamGia = _context.Coupons.SingleOrDefault(p => p.Id == product.CouponId);
                        var newPrice = product.Price * ( 1 - giamGia.Value /100);
                        product.Price = newPrice;
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
                }, "Value" , "Text",product.Status

            );

            ViewData["Condition"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "default", Value = "default"},
                    new SelectListItem { Text = "hot", Value = "hot"},
                    new SelectListItem { Text = "new", Value = "new"},

                }, "Value" , "Text",product.Condition

            );
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Slug", product.BrandId);
            ViewData["CatId"] = new SelectList(_context.Categories, "Id", "Slug", product.CatId);
            ViewData["ChildCatId"] = new SelectList(_context.Categories, "Id", "Slug", product.ChildCatId);
            ViewData["CouponId"] = new SelectList(_context.Coupons, "Id", "Code", product.CouponId);
            return View(product);
        }

        // GET: Product/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Cat)
                .Include(p => p.ChildCat)
                .Include(p => p.Coupon)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [Route("delete")]
        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ulong id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(ulong id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
