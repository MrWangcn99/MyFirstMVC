using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace WebAppStudy.Unitity.AOP
{
    public class CachingBehavior : IInterceptionBehavior
    {

        public bool WillExecute => true;

        private static Dictionary<string, object> CachingBehaviorDictionary = new Dictionary<string, object>();

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            IMethodReturn @return;
            Console.WriteLine("CachingBehavior");
            string key = $"{input.MethodBase.Name}_{JsonConvert.SerializeObject(input.Inputs)}";
            if (CachingBehaviorDictionary.ContainsKey(key))
            {
                return input.CreateMethodReturn(CachingBehaviorDictionary[key]);//如果存在了就不用进入下一层 直接返回就好
            }
            else
            {
                @return = getNext().Invoke(input, getNext);//这里才进入下一层
                if (@return.ReturnValue != null)
                    CachingBehaviorDictionary.Add(key, @return.ReturnValue);//用字典缓存 
                CachingBehaviorDictionary.Add(key, @return.ReturnValue);
                return @return;
            }
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }
    }
}