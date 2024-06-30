using MyFirstcWebcore.Unitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppStudy.Controllers
{
    public class FirstController : Controller
    {
        //private object model="ReChard";

        // GET: First

        Logger _logger = new Logger(typeof(FirstController));
        public ActionResult Index()
        {
                base.ViewBag.User1 = "张三";
                base.ViewData["User2"] = "李四";
                base.TempData["User3"] = "王五";
                base.HttpContext.Session["User4"] = "赵六";
                object model = "ReChard";
           
               return View(model);
        }
        public ActionResult TownView()
        {
            _logger.Info("FirstControl--TownView--info");
            _logger.Error("FirstControl--TownView--error");
            _logger.Debug("FirstControl--TownView--debug");
            _logger.Warn("FirstControl--TownView--warn");
            return View();

        }
    }
}