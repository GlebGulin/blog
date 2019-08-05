using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Models.Data;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Blog.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("admin")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Area("admin")]
        [HttpPost]
        public IActionResult Index(UserViewModel us)
        {
            using (Db db = new Db())
            {
                if ( db.user.Any( x=> x.Name == us.Name) && db.user.Any( x => x.Pass == us.Pass))
                {
                    TempData["Enter"] = "Успешно";
                    const string Access = "Access";
                    HttpContext.Session.SetString(Access, "True");
                    return RedirectToAction("Index", "Panel");
                }
                else
                {
                    TempData["NotEnter"] = "Неверный логин или пароль";
                    return View(us);
                }
            }
                
        }
        [Area("admin")]
        [HttpGet]
        public IActionResult ChangeSetting (int id = 1)
        {
            UserViewModel usv;
            using (Db db = new Db())
            {
                User users = db.user.Find(id);
               
                usv = new UserViewModel(users);

            }
            return View(usv);
        }
        [Area("admin")]
        [HttpPost]
        public IActionResult ChangeSetting(UserViewModel usr)
        {
            using (Db db = new Db())
            {
               
               
                if (usr.Pass!=usr.PassCoFirm)
                {
                    TempData["ComparePass"] = "Пароли не совпадают";
                    return View(usr);
                }
                else
                {

                    int id = 1;
                    User user = db.user.Find(id);
                    TempData["ComparePassTrue"] = "пароль успешно изменен";
                    user.Name = usr.Name;
                    user.Pass = usr.Pass;
                    db.SaveChanges();
                    
                }
                return View("Index");

            }
        }


    }
}