using Blog.Models.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewModels
{
    public class ArticleViewModel
    {
        public ArticleViewModel()
        {

        }
        public ArticleViewModel(Articles row)
        {
            Id = row.Id;
            Title = row.Title;
            Sorting = row.Sorting;
            Urlimg = row.Urlimg;
            Content = row.Content;
            Timepost = row.Timepost;
            Slug = row.Slug;
            coms = row.coms;
        }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        //[Required]
        public string Slug { get; set; }
        public int Sorting { get; set; }
        public string Urlimg { get; set; }
        public string Content { get; set; }
        public DateTime Timepost { get; set; }
        public ICollection<Comments> coms { get; set; }
        //public IFormFile picblog { get; set; }

        //public IFormFile SomeFile { get; set; }
    }
}
