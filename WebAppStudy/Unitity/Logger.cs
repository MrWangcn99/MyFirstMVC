using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyFirstcWebcore.Unitity
{
    public class Logger
    {   
        static Logger()
        {
           var ss= XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\log4net.config")));
            ILog log = LogManager.GetLogger(typeof(Logger));
            log.Info("系统初始化Log模块");
        }
        private ILog loger = null;
        public Logger(Type type)
        {
            loger = LogManager.GetLogger(type);
        }
        public void Error(string msg = "出现异常", Exception ex = null)
        {
            Console.WriteLine(msg);
            loger.Error(msg, ex);
        }
        public void Warn(string msg )
        {
            Console.WriteLine(msg);
            loger.Warn(msg);
        }
        public void Info(string msg)
        {
            Console.WriteLine(msg);
            loger.Info(msg);
        }
        public void Debug(string msg)
        {
            Console.WriteLine(msg);
            loger.Debug(msg);
        }
    }
}