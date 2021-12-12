using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class Cart
    {
        public Cart()
        {
            Wishlists = new HashSet<Wishlist>();
        }

        public ulong Id { get; set; }
        public ulong ProductId { get; set; }
        public ulong? OrderId { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ShopUser User { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
