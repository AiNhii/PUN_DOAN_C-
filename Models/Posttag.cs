using System;
using System.Collections.Generic;

#nullable disable

namespace Web_db.Models
{
    public partial class Posttag
    {
        public Posttag()
        {
            Postsandtags = new HashSet<Postsandtag>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Postsandtag> Postsandtags { get; set; }
    }
}
