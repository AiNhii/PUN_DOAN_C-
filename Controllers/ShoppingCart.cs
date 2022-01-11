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
using Microsoft.AspNetCore.Identity;
using System.Text;
using Microsoft.Extensions.Configuration;
using BraintreeHttp;
using PayPal.v1.Payments;
using Microsoft.AspNetCore.Authorization;

namespace comestic_csharp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShopDbContext _context;
        private readonly UserManager<ShopUser> _userManager;

        private readonly string _clientId;
        private readonly string _secretKey;

        public double TyGiaUSD = 22500;



        public ShoppingCartController(ShopDbContext context,UserManager<ShopUser> userManager, IConfiguration config)
        {
            _context = context;
            _userManager = userManager;
            _clientId = config["PaypalSettings:ClientId"];
            _secretKey = config["PaypalSettings:SecretKey"];
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

        void SaveCartSession (List<CartItem> ls) {
                    var session = HttpContext.Session;
                    string jsoncart = JsonConvert.SerializeObject (ls);
                    session.SetString (CARTKEY, jsoncart);
        }

        void ClearCart () 
        {
            var session = HttpContext.Session;
            session.Remove (CARTKEY);
        }

            // Lưu Cart (Danh sách CartItem) vào session
        // public IActionResult AddToCart (ulong id) {        

        //     var product = _context.Products
        //         .Where (p => p.Id == id)
        //         .FirstOrDefault ();
        //     if (product == null)
        //         return NotFound ("Không có sản phẩm");

        //     // Xử lý đưa vào Cart ...
        //     var cart = GetCartItems ();
        //     var cartitem = cart.Find (p => p.Product.Id == id);
        //     if (cartitem != null) {
        //         // Đã tồn tại, tăng thêm 1
        //         cartitem.Quantity++;
        //     } else {
        //         //  Thêm mới
        //         cart.Add (new CartItem () { Quantity = 1, Product = product });
        //     }

        //     // Lưu cart vào Session
        //     SaveCartSession (cart);
        //     // Chuyển đến trang hiện thị Cart
        //     return RedirectToAction ("Cart");
        // }


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

            public IActionResult Checkout()
            {
                return View (GetCartItems());
            }


            public string RandomString()  
            {  
                int Numrd;
                string Numrd_str;
                Random rd = new Random();
                Numrd = rd.Next(1, 100);//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
                Numrd_str = rd.Next(1, 100).ToString();//Chuyển giá trị ramdon về kiểu string
                
                return  Numrd_str;
            }  


        [HttpPost]
        public IActionResult ApplyCoupon (string coupon){
            var cart = GetCartItems ();
            ulong id = 0;
            decimal save =0;
            decimal total = 0;
            decimal final =0;
            var cp = _context.Coupons.SingleOrDefault(p => p.Code == coupon);
        
            if (coupon != null){
                foreach(var item in cart){
                    var thanhtien = item.Quantity * item.Product.Price;
				    total += thanhtien;	
                }
            }

            if (cp.EndedAt < DateTime.Now)
            {
                id = 0;
                final = total;
            }
            else
            {
                save = total * cp.Value/ 100;
                final = total*(1- cp.Value /100);
                id = cp.Id;
            }

            HttpContext.Session.SetInt32("save", (int)save);
            HttpContext.Session.SetInt32("final", (int)final);
            HttpContext.Session.SetInt32("couponId", (int)id);

            return Json( new { status = "success", total = final, save = save, id = id});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult testCheckout(string FirstName, string LastName, string Address, string Email, string Phone, int payment)
        {
            
            List<CartItem> cart = GetCartItems();
            decimal save =0;
            decimal total = 0;

            if(HttpContext.Session.GetInt32("save") != null)
                    save = (int)HttpContext.Session.GetInt32("save");
            

            foreach( var item in cart){
                var thanhtien = item.Quantity * item.Product.Price;
				total += thanhtien;	
            }

            if (ModelState.IsValid)
            {
                var donhang = new Models.Order();
                donhang.OrderNumber= "ORDER"+ RandomString();
                if (User.Identity.IsAuthenticated){
                    donhang.UserId = _userManager.GetUserId(User);
                }
                if(HttpContext.Session.GetInt32("couponId") != 0){
                    donhang.CouponId = (ulong?)HttpContext.Session.GetInt32("couponId");
                }
                donhang.FirstName = FirstName;
                donhang.LastName = LastName;
                donhang.Email = Email;
                donhang.Address = Address;
                donhang.Phone = Phone;
                donhang.TotalAmount = total - save ;
                donhang.SubTotal = total;
                donhang.CreatedAt = DateTime.Now;
                if( payment != 1 ){
                    donhang.PaymentMethod ="paypal";
                    donhang.PaymentStatus ="paid";
                }
                else{
                    donhang.PaymentMethod ="cod";
                    donhang.PaymentStatus ="unpaid";
                }
                
                donhang.Status ="new";

                _context.Add(donhang);
                _context.SaveChanges();

                        foreach( var item in cart){
                             Orderdetail _orderDetail = new Orderdetail();
                             _orderDetail.OrderId = donhang.Id;
                             _orderDetail.ProductId = item.Product.Id;
                             _orderDetail.Quantity = item.Quantity;
                             _orderDetail.Price = item.Product.Price;
                             _orderDetail.Total =  item.Product.Price * item.Quantity;
                             _context.Add(_orderDetail);
                        }
                         _context.SaveChanges();

                HttpContext.Session.Remove("save");
                HttpContext.Session.Remove("final");
                HttpContext.Session.Remove("couponId");
                HttpContext.Session.Remove("cart");
            }
            return RedirectToAction("Index","Home");
        }

        [Authorize]
        public async Task<IActionResult> PaypalCheckout()
        {
            var environment = new PayPal.Core.SandboxEnvironment(_clientId, _secretKey);
            var client = new PayPal.Core.PayPalHttpClient(environment);

            List<CartItem> cart = GetCartItems();

            decimal save =0;
            double _total = 0;

            if(HttpContext.Session.GetInt32("save") != null)
                    save = (int)HttpContext.Session.GetInt32("save");

            foreach( var item in cart){
                var thanhtien = item.Quantity * item.Product.Price;
				_total += (double)thanhtien;	
            }

            #region Create Paypal Order
            var itemList = new ItemList()
            {
                Items = new List<PayPal.v1.Payments.Item>()
            };

            var total = Math.Round(_total / TyGiaUSD, 2);
            foreach (var item in cart)
            {
                itemList.Items.Add(new PayPal.v1.Payments.Item()
                {
                    Name = item.Product.Title,
                    Currency = "USD",
                    Price = Math.Round((double)item.Product.Price / TyGiaUSD, 2).ToString(),
                    Quantity = item.Quantity.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }
            #endregion

            var paypalOrderId = DateTime.Now.Ticks;
            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = (total-(double)save).ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = total.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = $"Invoice #{paypalOrderId}",
                        InvoiceNumber = paypalOrderId.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = $"{hostname}/ShoppingCart/Checkout",
                    ReturnUrl = $"{hostname}/ShoppingCart/CheckoutSuccess"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {


                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                        
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (BraintreeHttp.HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return Redirect("/ShoppingCart/CheckoutFail");
            }
        }

        public IActionResult CheckoutFail()
        {
            return RedirectToAction("Checkout","ShoppingCart");
        }
        
        public IActionResult CheckoutSuccess()
        {
            List<CartItem> cart = GetCartItems();
            decimal save =0;
            decimal total = 0;

            if(HttpContext.Session.GetInt32("save") != null)
                    save = (int)HttpContext.Session.GetInt32("save");
            

            foreach( var item in cart){
                var thanhtien = item.Quantity * item.Product.Price;
				total += thanhtien;	
            }

            if (ModelState.IsValid)
            {
                var donhang = new Models.Order();
                donhang.OrderNumber= "ORDER"+ RandomString();
                if (User.Identity.IsAuthenticated){
                    donhang.UserId = _userManager.GetUserId(User);
                }
                if(HttpContext.Session.GetInt32("couponId") != 0){
                    donhang.CouponId = (ulong?)HttpContext.Session.GetInt32("couponId");
                }
                donhang.FirstName = "FirstName";
                donhang.LastName =  "LastName";
                donhang.Email =  "Email";
                donhang.Address =  "Address";
                donhang.Phone =  "Phone";
                donhang.TotalAmount = total - save ;
                donhang.SubTotal = total;
                donhang.CreatedAt = DateTime.Now;
                donhang.PaymentMethod ="paypal";
                donhang.PaymentStatus ="paid";
                donhang.Status ="new";

                _context.Add(donhang);
                _context.SaveChanges();

                        foreach( var item in cart){
                             Orderdetail _orderDetail = new Orderdetail();
                             _orderDetail.OrderId = donhang.Id;
                             _orderDetail.ProductId = item.Product.Id;
                             _orderDetail.Quantity = item.Quantity;
                             _orderDetail.Price = item.Product.Price;
                             _orderDetail.Total =  item.Product.Price * item.Quantity;
                             _context.Add(_orderDetail);
                        }
                         _context.SaveChanges();

                HttpContext.Session.Remove("save");
                HttpContext.Session.Remove("final");
                HttpContext.Session.Remove("couponId");
                HttpContext.Session.Remove("cart");
            }
            return RedirectToAction("Index","Home");
        }
    }
}