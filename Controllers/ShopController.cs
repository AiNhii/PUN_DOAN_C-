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
using PagedList.Core;

namespace comestic_csharp.Controllers
{

    public class ShopController : Controller
    {
        private readonly ShopDbContext _context;

        public ShopController(ShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 6;
            var products = _context.Products.OrderByDescending(x => x.Price);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;
            return View(model);
        }
        public IActionResult list(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 6;
            var products = _context.Products.OrderByDescending(x => x.Price);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;
            return View(model);
        }

        // public async Task<IActionResult> list()
        // {
        //     return View(await _context.Products.ToListAsync());
        // }

        public async Task<IActionResult> Details(ulong? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }


    }
}