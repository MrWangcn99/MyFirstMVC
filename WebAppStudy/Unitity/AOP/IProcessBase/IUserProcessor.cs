using SqlResource.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppStudy.Unitity.AOP.Att;

namespace WebAppStudy.Unitity.AOP.IProcessBase
{
  
        /// <summary>
        /// 特性添加可以忽略Attribute字符串
        ///</summary>
        [ExceptionLogingBehavior]
        [LogBeforeBehavior]
        [LogAfterBehavior]
        [ParameterCheckBehavior]
        [CachingBehavior]

        public interface IUserProcessor
        {
            //提交订单
            // int SubmitOrder();
            //标注就拦截
            [ExceptionLogingBehavior]
            [LogBeforeBehavior]
            [LogAfterBehavior]
            [ParameterCheckBehavior]
            [CachingBehavior]
            void RegUser(User user);
            User GetUser(User user);
    }
    
}