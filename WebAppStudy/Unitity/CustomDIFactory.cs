using Bussiness.Interface;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace WebAppStudy.Unitity
{
    public class CustomDIFactory
    {

        private static IUnityContainer _container = new UnityContainer();
        /// <summary>
        /// 静态构造函数只会执行一次
        /// </summary>
        static CustomDIFactory()
        {
            //读取配置文件
            ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
            FileMap.LocalUserConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.config");
            FileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.config");
            Configuration configuratiion = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)configuratiion.GetSection(UnityConfigurationSection.SectionName);
             section.Configure(_container, "WCNContainer");
        }
        public static IUnityContainer GetContaner()
        {
            return _container;
        }
    }
}