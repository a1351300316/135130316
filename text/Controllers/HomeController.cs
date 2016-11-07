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
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult List()
        {
            string[] data = new string[] { "台风逼近广西景区关闭学校停课",
                "广西每年入境游客超300万" ,
                "空军招飞初选10月24日开始",
                "柳州城市轨道交通勘探工作已展开"};

            //ViewBag.data = data;
            //ViewData["data"] = data;
            ViewData.Model = data;
            return View();
        }
    }
}