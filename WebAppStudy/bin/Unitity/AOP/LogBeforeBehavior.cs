using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;
using WebAppStudy.Unitity.AOP.Att;

namespace WebAppStudy.Unitity.AOP
{
    class LogBeforeBehavior : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn @return;
            //判断是否使用了特性LogBeforeBehaviorAttribute，如果是就进来
            if (input.MethodBase.IsDefined(typeof(LogBeforeBehaviorAttribute), false))
            {
                Console.WriteLine("LogBeforeBehavior");
                Console.WriteLine($"方法名称是{input.MethodBase.Name}");
                foreach (var item in input.Inputs)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(item));//序列化或者反射获取更多信息
                }
            }
            @return = getNext().Invoke(input, getNext);
            return @return;
        }
    }
}