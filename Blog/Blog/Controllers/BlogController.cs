using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Blog.Models.Data;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            using (Db db = new Db())
            {
                var post = db.article.Include(X => X.coms).ToList();
                return View(post);
            }

        }
        [HttpGet]
        public IActionResult Lookpost (int id)
        {
           
            using (Db db = new Db())
            {
                
                Articles article = db.article.Find(id);
                
                return View(article);
            }

           
            
        }
        [HttpPost]
        public IActionResult Postcomment(CommentsViewModel commentsViewModel)
        {
            Db db = new Db();
            try
            {
                Comments comment = new Comments();
                comment.Comment = commentsViewModel.Comment;
                comment.Mail = commentsViewModel.Mail;
                comment.ArticlesId = commentsViewModel.ArtId;

                comment.Timecomment = DateTime.Now;
                db.comment.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                Response.StatusCode = 500;
                return Content(ex.Message);
            }

        }


    }
}