using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlResource
{
    class Progrees
    {
        [STAThread]
        static void Main()
        {
            using (var context = new CustomDbContect())
            {
                var users = context.Users.ToList(); // 查询所有用户
                var specificUser = context.Users.FirstOrDefault(u => u.Id == 1); // 根据ID获取特定用户
            }
        }
    }
}
