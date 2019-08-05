using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.admin.Controllers
{
    public class PanelController : Controller
    {
        [Area("admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}