using Bussiness.Interface;
using Bussiness.Service;
using Microsoft.Practices.Unity.Configuration;
using SqlResource;
using System;
using System.Configuration;
using System.IO;
using System.Web.Mvc;
using Unity;
using WebAppStudy.Unitity;

namespace WebAppStudy.Controllers
{
    public class ThirdController : Controller
    {
        // GET: Third
        private CustomDbContect dbContect = null;
         public ThirdController(CustomDbContect customDbContect)
        {
           
        }
        public ThirdController()
        {

        }
        public ActionResult Index()
        {
            IUnityContainer Container = CustomDIFactory.GetContaner();
            IUserService userService = Container.Resolve<IUserService>();
            var ss = userService.Find();
            return View();
        }
    }
}