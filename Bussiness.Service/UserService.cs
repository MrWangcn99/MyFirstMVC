using Bussiness.Interface;
using Microsoft.EntityFrameworkCore;
using SqlResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Service
{
   public class UserService: IUserService
    {
        private CustomDbContect _db = null;
        public UserService(CustomDbContect dbContext)
        {
            _db = dbContext;
        }
        public object Find()
        {
           return _db.Users.ToList();
           // return _db.Users.FirstOrDefault();
        }
    }
}
