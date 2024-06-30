using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource.Table
{
   public class RecordClass
    {
        [Key]
        public int Id { get; set; }//序号
        public int CargoId { get; set; }//物资id
        public string Tag { get; set; }//备注
        public int Number { get; set; }//入库出库流水
        public DateTime InsertTime { get; set; }
        public int UseID { get; set; }//操作员ID
        public string UserName { get; set; }//操作员名称
    }
}
