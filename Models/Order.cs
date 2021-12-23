﻿using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class Order
    {
    

        public ulong Id { get; set; }
        public string OrderNumber { get; set; }
        public ulong? ProductId { get; set; }
        public string UserId { get; set; }
        public decimal SubTotal { get; set; }
        public ulong? ShippingId { get; set; }
        public ulong? CouponId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual Shipping Shipping { get; set; }
        public virtual ShopUser User { get; set; }
        public virtual ICollection<Orderdetail> Orderdetail { get; set; }
    }
}
