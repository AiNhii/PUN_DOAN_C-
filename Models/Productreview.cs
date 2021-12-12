using System;
using System.Collections.Generic;
using comestic_csharp.Areas.Identity.Data;

#nullable disable

namespace comestic_csharp.Models
{
    public partial class Productreview
    {
        public ulong Id { get; set; }
        public string UserId { get; set; }
        public ulong? ProductId { get; set; }
        public sbyte Rating { get; set; }
        public string Review { get; set; }
        public string Status { get; set; }

        public virtual Product Product { get; set; }
        public virtual ShopUser User { get; set; }
    }
}
