using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource.Table
{
   public class CargoClass
    {
        public int Id { get; set; }//序号
        [Key]
        public string Name { get; set; }//物资名称
        public string TypeName { get; set; }//物资类型名称
        public string Unit { get; set; }//物资单位
        public float Price { get; set; }//价格
        public string Tag { get; set; }//备注
        public DateTime InsertTime { get; set; }//插入时间
        public int UseID { get; set; }//操作员ID
        public string UserName { get; set; }//操作员名称
    }
}
