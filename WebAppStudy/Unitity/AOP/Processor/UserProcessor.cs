using SqlResource.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppStudy.Unitity.AOP.IProcessBase;

namespace WebAppStudy.Unitity.AOP.Processor
{
    public class UserProcessor : IUserProcessor
    {
        public User GetUser(User user)
        {
            return user;
        }

        public void RegUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}