using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Wen.DAL;
using Wen.Models;

namespace Wen.BLL
{
    /// <summary>
    /// 用户的业务逻辑层
    /// </summary>
    public class SysAdminBLL
    {
        /// <summary>
        /// 创建数据访问类的对象
        /// </summary>
        public SysAdminDAL sysAdminDAL=new SysAdminDAL();

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public  SysadminsModel SelectUser(SysadminsModel admin)
        {
            return sysAdminDAL.GetUser(admin);
        }


        /// <summary>
        /// 保存用户账号和密码
        /// </summary>
        /// <param name="admin"></param>
        public void SaveUser(SysadminsModel admin)
        {
            sysAdminDAL.SaveAdmin(admin);
        }
        /// <summary>
        /// 读取用户和密码
        /// </summary>
        /// <returns></returns>
        public SysadminsModel ReadUser() 
        {
          return   sysAdminDAL.ReadUser();
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        public void DeleteUser()
        {
            sysAdminDAL.DeleteUser();
        }
    }
}
