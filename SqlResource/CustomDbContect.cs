using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SqlResource.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource
{
    public class CustomDbContect: DbContext
    {
        public CustomDbContect()
        { }
        public CustomDbContect(DbContextOptions<CustomDbContect>options)
         : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connect = ConfigurationManager.AppSettings["mysqlConnect"];
            string connect = "server=localhost;database=mytest;uid=root;pwd=123456";
            optionsBuilder.UseMySQL(connect);
        }
       // public virtual DbSet<Company> GetCompanies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<RecordClass> GetRecordClass { get; set; }
        public virtual DbSet<CargoTypeClass> GetCargoTypeClass { get; set; }
        public virtual DbSet<CargoClass> GetCargoClass { get; set; }
    }
}
