﻿using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class Wishlist
    {
        public ulong Id { get; set; }
        public ulong ProductId { get; set; }
        public ulong? CartId { get; set; }
        public string UserId { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
        public virtual ShopUser User { get; set; }
    }
}
