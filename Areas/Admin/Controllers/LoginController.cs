using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BCryptNet = BCrypt.Net.BCrypt;
using Microsoft.Extensions.Logging;
using comestic_csharp.Models;
using comestic_csharp.Security;
using Org.BouncyCastle.Crypto.Generators;
using Microsoft.AspNetCore.Http;

namespace comestic_csharp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Login")]
    public class LoginController : Controller
    {
        private ShopContext db = new ShopContext();

        private SecurityManager securityManager = new SecurityManager();

        public LoginController(ShopContext _db){
            db= _db;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string email, string password){
            var user = db.Users.SingleOrDefault( u => u.Email == email);
            if ( user != null){
                securityManager.SignIn(this.HttpContext, user);
                return RedirectToAction("index","Dashboard", new { area = "Admin"});

            } else {
                ViewBag.error = "Invalid User";
                return View("Index");
            }
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(string email, string password)
        {
            var _admin = db.Users.Where(s => s.Email == email);
            if(_admin.Any()){
                if(_admin.Where(s => s.Password == password).Any()){

                    HttpContext.Session.SetString("email", email);       
                    return RedirectToAction("index","Dashboard", new { area = "Admin"}) ;
                    
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!"});
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!"});
            }
        }

        private User processLogin(string email, string password){
            var user = db.Users.SingleOrDefault( u => u.Email == email);
            if ( user != null){
                if (BCrypt.Net.BCrypt.Verify(password, user.Password)){
                    return user;
                }
            }
            return null;
        }


        // [Route("signout")]
        // public IActionResult SignOut(){
        //     securityManager.SignOut(this.HttpContext);
        //     return RedirectToAction("index","Login", new { area = "admin"});
        // }


        [Route("accessdenied")]
        public IActionResult AccessDenied(){
            return View();
        }


    }
}