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
    public class LogAfterBehavior : IInterceptionBehavior
    {
        public bool WillExecute =>true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn @return = getNext().Invoke(input, getNext);//表示先把之前的执行了然后在往后执行我们添加的
            if (input.MethodBase.IsDefined(typeof(LogAfterBehaviorAttribute), false))
            {
                Console.WriteLine("LogAfterBehavior");
                Console.WriteLine(input.MethodBase.Name);
                foreach (var item in input.Inputs)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(item));//序列化或者反射获取更多信息
                }
            }
            return @return;
        }
    }
}