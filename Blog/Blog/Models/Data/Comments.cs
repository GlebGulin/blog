using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Data
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Comment { get; set; }
        public int ArticlesId { get; set; }
        [ForeignKey("ArticlesId")]
        public virtual Articles Articles { get; set; }
        public DateTime Timecomment { get; set; }

        public Comments()
        {
            Timecomment = DateTime.Now;
        }

    }
}
