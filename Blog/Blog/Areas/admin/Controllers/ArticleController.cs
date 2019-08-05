using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Data;
using Blog.Models.Translitor;
using Blog.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;

namespace Blog.Areas.admin.Controllers
{
    
    public class ArticleController : Controller
    {
        
        private readonly IHostingEnvironment he;
        public ArticleController(IHostingEnvironment e)
        {
            he = e;
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult Index()
        {
            List<ArticleViewModel> articleViewModels;
            using (Db db = new Db())
            {
                articleViewModels = db.article.ToArray().OrderBy(x => x.Sorting).Select(x => new ArticleViewModel(x)).ToList();
            }
            return View(articleViewModels);
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }
        [Area("admin")]
        [HttpPost]
        //[HttpPost("UploadFiles")]
        public IActionResult AddPost (ArticleViewModel art, IFormFile SomeFile)
        {
            using (Db db = new Db())
            {
                if (!ModelState.IsValid)
                {
                    return View(art);
                }
                string postlink;
                Articles newart = new Articles();
                newart.Title = art.Title;
                if(string.IsNullOrWhiteSpace(art.Slug))
                {
                    postlink = art.Title.ToLower();
                    Translitor translitor = new Translitor();
                    foreach (KeyValuePair<string, string> pair in translitor.words)
                    {
                        postlink = postlink.Replace(pair.Key, pair.Value);

                    }
                }
                else
                {
                    postlink = art.Slug.ToLower();
                    Translitor translitor = new Translitor();
                    foreach (KeyValuePair<string, string> pair in translitor.words)
                    {
                        postlink = postlink.Replace(pair.Key, pair.Value);

                    }
                }
                if (db.article.Any(x => x.Title == art.Title) || db.article.Any(x => x.Slug == art.Slug))
                {
                    ModelState.AddModelError(" ", "Такое название поста или ссылка уже существуют ");
                    return View(art);
                }
                //newart.Urlimg = art.Urlimg;
                newart.Slug = postlink;
                newart.Content = art.Content;
                newart.Sorting = 100;
                //Add post's picture
                var picblog = SomeFile;
                if (picblog != null)
                {
                    var fileName = Path.Combine(he.WebRootPath + "\\images\\", Path.GetFileName(picblog.FileName));
                    string picturelink = "/images/" + SomeFile.FileName;
                    picblog.CopyTo(new FileStream(fileName, FileMode.Create));
                    ViewData["filelocation"] = fileName;
                    newart.Urlimg = picturelink;
                }

                db.article.Add(newart);
                db.SaveChanges();



            }
            TempData["SM"] = "Успешно добавлено";
            return RedirectToAction("AddPost");
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult EditPost (int id)
        {
            ArticleViewModel articleViewModel;
            using (Db db = new Db())
            {
                Articles articles = db.article.Find(id);
                if (articles == null)
                {
                    return Content("Статья блога не создана");
                }
                articleViewModel = new ArticleViewModel(articles);
                


            }
            return View(articleViewModel);
        }
        [Area("admin")]
        [HttpPost]
        public IActionResult EditPost(ArticleViewModel articleViewModel, IFormFile SomeFileUpdate)
        {
            if(!ModelState.IsValid)
            {
                return View(articleViewModel);
            }
            using (Db db = new Db())
            {
                int id = articleViewModel.Id;
                Articles articles = db.article.Find(id);
                articles.Title = articleViewModel.Title;
                string postlink;
                if (string.IsNullOrWhiteSpace(articleViewModel.Slug))
                {
                    postlink = articleViewModel.Title.ToLower();
                    Translitor translitor = new Translitor();
                    foreach (KeyValuePair<string, string> pair in translitor.words)
                    {
                        postlink = postlink.Replace(pair.Key, pair.Value);

                    }

                }
                else
                {
                    postlink = articleViewModel.Slug.ToLower();
                    Translitor translitor = new Translitor();
                    foreach (KeyValuePair<string, string> pair in translitor.words)
                    {
                        postlink = postlink.Replace(pair.Key, pair.Value);

                    }
                }
                if (db.article.Where(x => x.Id != id).Any(x => x.Title == articleViewModel.Title) ||
                       (db.article.Where(x => x.Id != id).Any(x => x.Slug == articleViewModel.Slug)))
                {
                    //return Content("Страница с такой ссылкой или названием уже существует");
                    //ModelState.AddModelError(" ", "Страница с такой ссылкой или названием уже существует");
                    TempData["Error"] = "Error";
                    return View(articleViewModel);
                    //return RedirectToAction("Edit");
                }
                var picblog = SomeFileUpdate;
                //if (articles.Urlimg != null)
                //{
                    if (picblog != null)
                    {
                        //articleViewModel.Urlimg = null;

                        var fileName = Path.Combine(he.WebRootPath + "\\images\\", Path.GetFileName(picblog.FileName));
                        string picturelink = "/images/" + SomeFileUpdate.FileName;
                        picblog.CopyTo(new FileStream(fileName, FileMode.Create));
                        ViewData["filelocation"] = fileName;
                        articles.Urlimg = picturelink;
                    }
                    else
                    {
                        articles.Urlimg = articleViewModel.Urlimg;
                    }
                //}
                //else
                //{
                //    articles.Urlimg = 
                //}
                articles.Slug = postlink;
                articles.Content = articleViewModel.Content;
                articles.Timepost = articleViewModel.Timepost;
                db.SaveChanges();
            }
            TempData["SM"] = "Изменения сохранены";

            return View("EditPost");
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult PostDelete(int id)
        {
            //ArticleViewModel articleViewModel;
            using (Db db = new Db())
            {
                Articles articles = db.article.Find(id);
                db.article.Remove(articles);
                db.SaveChanges();
            }
            TempData["Del"] = "Запись успешно удалена";
            return RedirectToAction("Index");
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult PostDetails(int id)
        {
            ArticleViewModel articleViewModel;
            using (Db db = new Db())
            {
                Articles article = db.article.Find(id);
                if (article == null)
                {
                    TempData["NotFound"] = "Запись не найдена";
                }
                articleViewModel = new ArticleViewModel(article);
            }

                return View(articleViewModel);
        }
        [Area("admin")]
        [HttpPost]
        public void RewriteList(int[] id)
        {
            using (Db db = new Db())
            {
               
                int count = 1;
                Articles articles;
                foreach (var pageId in id)
                {
                    articles = db.article.Find(pageId);
                    articles.Sorting = count;
                    db.SaveChanges();
                    count++;
                }
                //return View();
            }
        }


    }
}