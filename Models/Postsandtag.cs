using System;
using System.Collections.Generic;

#nullable disable

namespace Web_db.Models
{
    public partial class Postsandtag
    {
        public long Id { get; set; }
        public long? PostId { get; set; }
        public long? TagId { get; set; }

        public virtual Post Post { get; set; }
        public virtual Posttag Tag { get; set; }
    }
}
