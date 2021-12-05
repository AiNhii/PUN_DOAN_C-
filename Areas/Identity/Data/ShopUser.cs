using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;


namespace comestic_csharp.Areas.Identity.Data
{
    public class ShopUser : IdentityUser
    {
        public ShopUser()
        {
            Carts = new HashSet<Cart>();
            Categories = new HashSet<Category>();
            Orders = new HashSet<Order>();
            Postcomments = new HashSet<Postcomment>();
            Posts = new HashSet<Post>();
            Productreviews = new HashSet<Productreview>();
            Wishlists = new HashSet<Wishlist>();
        }

        public string Fullname { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Postcomment> Postcomments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Productreview> Productreviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}