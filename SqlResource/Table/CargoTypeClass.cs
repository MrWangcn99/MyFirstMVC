using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource.Table
{
   public class CargoTypeClass
    {
        public int Id { get; set; }//序号
        [Key]
        public string Name { get; set; }//物资名称
        public string Tag { get; set; }//备注
        public string NumberName { get; set; }//入库出库流水名
        public int NumberID { get; set; }//入库出库流水ID
    }
}
