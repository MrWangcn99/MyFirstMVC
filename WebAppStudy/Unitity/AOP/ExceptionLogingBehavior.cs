using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;
using WebAppStudy.Unitity.AOP.Att;

namespace WebAppStudy.Unitity.AOP
{
    public class ExceptionLogingBehavior : IInterceptionBehavior
    {
        bool IInterceptionBehavior.WillExecute => this.WillExecute();

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn @return;
            //如果启用了特性
            if (input.MethodBase.IsDefined(typeof(ExceptionLogingBehaviorAttribute), false))
            {
                @return = getNext().Invoke(input, getNext);
                Console.WriteLine("ExceptionLogingBehavior");
                if (@return.Exception == null)
                {
                    Console.WriteLine("无异常");
                }
                else
                {
                    Console.WriteLine($"无异常:{@return.Exception.Message}");
                }
            }
            //否则
            else
            {
                @return = getNext().Invoke(input, getNext);
            }
            return @return;
        }


        public bool WillExecute()
        {
            return true;
        }
    }
}