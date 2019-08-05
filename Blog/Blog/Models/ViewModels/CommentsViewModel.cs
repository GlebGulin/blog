using Blog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewModels
{
    public class CommentsViewModel
    {
        public CommentsViewModel()
        {

        }
        public CommentsViewModel(Comments row)
        {
            Id = row.Id;
            Mail = row.Mail;
            Comment = row.Comment;
            ArtId = row.ArticlesId;
            Timecomment = row.Timecomment;
        }
       
        public int Id { get; set; }
       
        public string Mail { get; set; }
       
        public string Comment { get; set; }
        public int ArtId { get; set; }
        
        
        public DateTime Timecomment { get; set; }
    }
}
