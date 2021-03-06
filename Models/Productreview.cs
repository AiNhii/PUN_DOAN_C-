using System;
using System.Collections.Generic;

#nullable disable

namespace Web_db.Models
{
    public partial class Productreview
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? ProductId { get; set; }
        public byte Rating { get; set; }
        public string Review { get; set; }
        public string Status { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
