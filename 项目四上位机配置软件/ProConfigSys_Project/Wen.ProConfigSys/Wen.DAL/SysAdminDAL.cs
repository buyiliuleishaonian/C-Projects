using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wen.Models;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wen.DAL
{
    /// <summary>
    /// 用户的数据访问层
    /// </summary>
    public class SysAdminDAL
    {
        string path = Application.StartupPath + "";
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="admin">包含账号和密码的用户对象</param>
        /// <returns></returns>
        public SysadminsModel GetUser(SysadminsModel admin)
        {
            string sql = "select sysadminId,adminName from sysadmins" +
                " where sysaccount=@sysaccount and adminpwd=@adminpwd";
            SqlParameter[] sqlparameter = new SqlParameter[]
            {
                new SqlParameter("@sysaccount",admin.Sysaccount),
                new SqlParameter("@adminpwd",admin.Adminpwd)
            };
            DataRow dr = SQLHelper.GetDataRow(sql, sqlparameter);
            if (dr != null)
            {
                admin.Adminname = dr["AdminName"].ToString();
                admin.Sysadminid = Convert.ToInt32(dr["Sysadminid"]);
            }
            return admin;
        }

        //存储用户名,通过文件流读取和写入文件
        //创建文件流，写入和读取文件
        //写入/读取/删除用户账号和密码
        /// <summary>
        /// 保存用户名
        /// </summary>
        /// <param name="admin"></param>
        public void SaveAdmin(SysadminsModel admin)
        {
            using (FileStream file=new FileStream("SysAdmin.obj",FileMode.OpenOrCreate,FileAccess.Write))
            { 
                BinaryFormatter bf= new BinaryFormatter();
                bf.Serialize(file, admin);
            }
        }

        /// <summary>
        /// 读取用户名
        /// </summary>
        /// <returns></returns>
        public SysadminsModel ReadUser()
        {
            if (File.Exists("SysAdmin.obj"))
            {
                using (FileStream file = new FileStream("SysAdmin.obj", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    SysadminsModel admin = (SysadminsModel)bf.Deserialize(file);
                    return admin;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 清除用户名
        /// </summary>
        public void DeleteUser()
        {
            if (File.Exists("SysAdmin.obj"))
            {
                File.Delete("SysAdmin.obj");
            }
        }
    }
}
