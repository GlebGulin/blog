using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Data
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Slug { get; set; }
        public int Sorting { get; set; }
        public string Urlimg { get; set; }
        public string Content { get; set; }
        public DateTime Timepost { get; set; }

        public virtual ICollection<Comments> coms { get; set; }
        public Articles()
        {
            Timepost = DateTime.Now;
        }
    }
}
