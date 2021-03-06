using System;
using System.Collections.Generic;

#nullable disable

namespace Web_db.Models
{
    public partial class Postcategory
    {
        public Postcategory()
        {
            Posts = new HashSet<Post>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
