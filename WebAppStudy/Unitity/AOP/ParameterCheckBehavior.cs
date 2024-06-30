using SqlResource.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;
using WebAppStudy.Unitity.AOP.Att;

namespace WebAppStudy.Unitity.AOP
{
    /// <summary>
    /// 检查数据行为
    /// </summary>
    class ParameterCheckBehavior : IInterceptionBehavior
    {
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        /// <summary>
        /// 添加新功能的逻辑方法
        /// </summary>
        /// <param name="input"></param>
        /// <param name="getNext"></param>
        /// <returns></returns>
        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn @return;
            if (input.MethodBase.IsDefined(typeof(ParameterCheckBehaviorAttribute), false))
            {
                Console.WriteLine("ParameterCheckBehavior");
                User user = input.Inputs[0] as User;//此处写死类型，也可以动态添加
                if (user.Id == 10)
                {
                    return input.CreateExceptionMethodReturn(new Exception("密码长度不能小于10"));//
                }
                else
                {
                    Console.WriteLine("参数检查无误");
                }
            }
            @return = getNext().Invoke(input, getNext);//执行后面的逻辑然后在添加新东西
            return @return;
        }
    }
}