using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAppStudy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 网站的初始化动作
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//注册区域
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//全局filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);//注册路由、转发信号用的
            BundleConfig.RegisterBundles(BundleTable.Bundles);//引用js/css需要的组件
            
        }
    }
}
