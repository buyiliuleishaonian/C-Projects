using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wen.Models
{
    [Serializable]//�����л�
    /// <summary>
    /// �û���
    /// </summary>
    public class SysadminsModel
    {
        /// <summary>
        /// ϵͳ��������ID
        /// </summary>
        public int Sysadminid { get; set; }
        /// <summary>
        /// ��ǰ�û�
        /// </summary>
        public string Sysaccount { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        public string Adminname { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string Adminpwd { get; set; }
    }
}

