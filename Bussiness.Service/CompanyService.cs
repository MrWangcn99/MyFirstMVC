using Bussiness.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Service
{
    class CompanyService:ICompanyService
    {
        public CompanyService(DbContext dbContext)
        {

        }
    }
}
