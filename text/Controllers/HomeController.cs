using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace text.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult News()
        {
            //ViewBage
            ViewBag.message = "hello";
            ViewBag.Date = DateTime.Now;


            //viewdata
            ViewData["message"] = "hello";
            ViewData["Date"] = DateTime.Now;

            string[] news = new string[]
            {

                "四道口附近哈老公看了",
                "收到了饭卡里说的法律是",
            };

            ViewBag.News = news;
            ViewData["News"] = news;
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
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }
    }
}