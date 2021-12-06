using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class CartItem
    {
        public CartItem()
        {
            Wishlists = new HashSet<Wishlist>();
        }

        public ulong ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}