using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;
using comestic_csharp.Areas.Identity.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace comestic_csharp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShopDbContext _context;

        public ShoppingCartController(ShopDbContext context)
        {
            _context = context;
        }

        // [Route ("/cart", Name = "cart")]
        public IActionResult Index()
        {
            // var shopContext = _context.Carts.Include(c => c.Order).Include(c => c.Product).Include(c => c.User);
            return View (GetCartItems());
        }

        public IActionResult Cart()
        {
            // var shopContext = _context.Carts.Include(c => c.Order).Include(c => c.Product).Include(c => c.User);
            return View (GetCartItems());
        }

        public const string CARTKEY = "cart";

    // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItems () {

        var session = HttpContext.Session;
        string jsoncart = session.GetString (CARTKEY);
        if (jsoncart != null) {
            return JsonConvert.DeserializeObject<List<CartItem>> (jsoncart);
        }
        return new List<CartItem> ();
        }


        void ClearCart () {
                    var session = HttpContext.Session;
                    session.Remove (CARTKEY);
                }

            // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession (List<CartItem> ls) {
                    var session = HttpContext.Session;
                    string jsoncart = JsonConvert.SerializeObject (ls);
                    session.SetString (CARTKEY, jsoncart);
        }


        public IActionResult AddToCart (ulong id) {        

            var product = _context.Products
                .Where (p => p.Id == id)
                .FirstOrDefault ();
            if (product == null)
                return NotFound ("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems ();
            var cartitem = cart.Find (p => p.Product.Id == id);
            if (cartitem != null) {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity++;
            } else {
                //  Thêm mới
                cart.Add (new CartItem () { Quantity = 1, Product = product });
            }

            // Lưu cart vào Session
            SaveCartSession (cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction ("Cart");
        }


        [HttpPost]
        public IActionResult UpdateCart (ulong id,int quantity) {
    // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems ();
            var cartitem = cart.Find (p => p.Product.Id == id);
            if (cartitem != null) {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity = quantity;
            }
            SaveCartSession (cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }


        // [Route ("/removecart/{productid:int}", Name = "removecart")]
            public IActionResult RemoveCart (ulong id) {
                var cart = GetCartItems ();
                var cartitem = cart.Find (p => p.Product.Id == id);
                if (cartitem != null) {
            // Đã tồn tại, tăng thêm 1
                    cart.Remove(cartitem);
                }

                SaveCartSession (cart);
                return RedirectToAction ("Cart");
            }
    }
}
