using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class Orderdetail
    {
        public ulong Id { get; set; }
        public ulong? OrderId { get; set; }
        public ulong? ProductId { get; set; }
        public decimal Price { get; set;}
        public int Quantity { get; set; }
        public decimal Total{ get; set; }
        
        public virtual Product Product { get; set; }
        public virtual Order Order {get; set;}

        
    }
}