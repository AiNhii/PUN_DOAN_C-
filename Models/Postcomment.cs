using System;
using System.Collections.Generic;

#nullable disable

namespace Web_db.Models
{
    public partial class Postcomment
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? PostId { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public long? ParentId { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
