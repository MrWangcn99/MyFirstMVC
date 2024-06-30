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
        /// ��վ�ĳ�ʼ������
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//ע������
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//ȫ��filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);//ע��·�ɡ�ת���ź��õ�
            BundleConfig.RegisterBundles(BundleTable.Bundles);//����js/css��Ҫ�����
            
        }
    }
}
