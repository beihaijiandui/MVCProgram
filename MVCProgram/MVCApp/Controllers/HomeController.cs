using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["One"] = "天机老人孙老头";
            ViewBag.Two = "子母龙凤环上官金虹";
            var _user = new User { Name = "小李飞刀李寻欢" };
            TempData["Four"] = "嵩阳铁剑郭嵩阳";
            return View(_user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}