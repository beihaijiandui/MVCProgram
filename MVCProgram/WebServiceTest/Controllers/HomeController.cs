using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServiceTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GetWeather()
        {
            return View();
        }
        /// <summary>
        /// 获得文本框录入的查询城市
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetWeather(string city)
        {
            //把WebService当做一个类来操作
            Weather.WeatherWebService client = new Weather.WeatherWebService();
            var s=client.getWeatherbyCityName(city);//string数组存放返回结果

            if (s[8] == "")
            {
                ViewBag.Msg = "暂时不支持您查询的城市";
            }
            else
            {
                ViewBag.ImgUrl = @"/Content/weather/" + s[8];
                ViewBag.General = s[1] + " " + s[6];
                ViewBag.Actually = s[10];
            }
            return View();
        }
    }
}