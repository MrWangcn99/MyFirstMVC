using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource.Table
{
   public class User
    {
        public int Id { get; set; }
        [Key]
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
