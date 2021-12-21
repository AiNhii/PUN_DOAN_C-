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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
namespace comestic_csharp.Controllers
{

    public class ShopController : Controller
    {
        private readonly ShopDbContext _context;
        private readonly UserManager<ShopUser> _userManager;
        private readonly SignInManager<ShopUser> _signInManager;

        public ShopController(ShopDbContext context, UserManager<ShopUser> userManager,
            SignInManager<ShopUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;

        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 9;
            var products = _context.Products;
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;

            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "Name", Value = "name"},

                }, "Value" , "Text"

            );

            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );
            return View(model);
        }

        public IActionResult List(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 10;
            var products = _context.Products;
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;
            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "Name", Value = "name"},

                }, "Value" , "Text"

            );

            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );

            return View(model);
        }

        public IActionResult Range(int? page){

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 9;
            var products = _context.Products.Where(p => p.Price <= 200000 && p.Price >=0);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;
            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "Name", Value = "name"},

                }, "Value" , "Text"

            );

            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );
            return View(model);
        }

        public IActionResult OrderByPriceA(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 10;
            var products = _context.Products.OrderBy(x => x.Price);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;

            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "Name", Value = "name"},

                }, "Value" , "Text"

            );

            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );
            return View(model);
        }

        public IActionResult OrderByPriceD(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 10;
            var products = _context.Products.OrderByDescending(x => x.Price);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;

            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "Name", Value = "name"},

                }, "Value" , "Text"

            );
            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );
            return View(model);
        }

        public IActionResult OrderByName(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pagesize = 10;
            var products = _context.Products.OrderByDescending(x => x.Title);
            PagedList<Product> model = new PagedList<Product>(products,pageNumber,pagesize);
            ViewBag.CurrentPage = pageNumber;

            ViewData["SortBy"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Order by Price Asc", Value = "asc"},
                    new SelectListItem { Text = "Order by Price Des", Value = "des"},
                    new SelectListItem { Text = "name", Value = "name"},

                }, "Value" , "Text"

            );
            
            ViewData["Show"] = new SelectList(

                 new List<SelectListItem>
                {
                    new SelectListItem { Text = "Dưới 200000", Value = "1"},
                    new SelectListItem { Text = "Từ 200000 - 500000", Value = "2"},
                    new SelectListItem { Text = "Trên 500000", Value = "3"},

                }, "Value" , "Text"

            );
            return View(model);
        }

        public IActionResult SortBy(string sort){

            var url = $"/Shop/";

            if(sort == "asc"){

                url = $"/Shop/OrderByPriceA";

            }
            if(sort == "des"){

               url = $"/Shop/OrderByPriceD";

            }

            if(sort == "name"){
                url = $"/Shop/OrderByName";
            }

            return Json( new { status = "success", redirectUrl = url});
        }
        
        public IActionResult Show(string show){

            var url = $"/Shop/Range";
                        
            return Json( new { status = "success", redirectUrl = url});
        }
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

        public async Task<IActionResult> ListMakeUp(ulong? id){
            var ShopDbContext = _context.Products.Where(p => p.CatId == id);
            return View(await ShopDbContext.ToListAsync());
        }

        public IActionResult SkinCare()
        {
            return View();
        }

        public IActionResult BestSeller()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var profile = _context.Users.First(p => p.UserName == HttpContext.Session.GetString("username"));
            return View(profile);
        }

        public IActionResult EditProfile(string id)
        {
            var profile = _context.Users.First(p => p.UserName == HttpContext.Session.GetString("username"));
            return View(profile);
        }

        public IActionResult UpdateProfile(ShopUser user)
        {
            var profile = _context.Users.First(p => p.UserName == HttpContext.Session.GetString("username"));
            profile.Fullname = user.Fullname;
            profile.Email = user.Email;
            profile.PhoneNumber = user.PhoneNumber;
            if(user.Photo != null){
                profile.Photo = user.Photo;
            }
            _context.Update(profile);
            _context.SaveChanges();
            return RedirectToAction("Profile");
        }

        public IActionResult Order()
        {
            var id = _context.Users.First(p => p.UserName == HttpContext.Session.GetString("username"));
            var order = _context.Orders.Where(p => p.UserId == id.Id);
            return View(order);
        }

        public IActionResult OrderDetails(ulong id)
        {
            var orderdetails = _context.Orderdetail.Where(p => p.OrderId == id);
            var order = _context.Orders.First(p => p.Id == id);
            ViewBag.Order = order;
            return View(orderdetails);
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public async Task<IActionResult> UpdatePassword(string cp, string np)
        {
            var user = await _userManager.GetUserAsync(User);
            var changePasswordResult = await _userManager.ChangePasswordAsync(user, cp, np);
            await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Index","Home");
        }

    }
}