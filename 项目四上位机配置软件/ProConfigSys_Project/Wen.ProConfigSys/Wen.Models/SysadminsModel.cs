using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wen.Models
{
    [Serializable]//可序列化
    /// <summary>
    /// 用户类
    /// </summary>
    public class SysadminsModel
    {
        /// <summary>
        /// 系统管理序列ID
        /// </summary>
        public int Sysadminid { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public string Sysaccount { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Adminname { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Adminpwd { get; set; }
    }
}

