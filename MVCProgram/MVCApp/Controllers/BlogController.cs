using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Message="ASP.NET MVC Application!";
            return View();
        }

        public ActionResult ShowArticle()
        {
            return View("Article");
        }

        public string Say()
        {
            return "Hello World!";
        }
    }
}