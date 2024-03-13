using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wen.Models
{
    /// <summary>
    /// 协议类型类
    /// </summary>
    public class ProtocoltypeModel
    {
        /// <summary>
        /// 协议ID
        /// </summary>
        public int PtypeId { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public int Etypeid { get; set; }
        /// <summary>
        /// 协议名称
        /// </summary>
        public string Ptypename { get; set; }

        //扩展外键属性
        public string EtypeName { get; set; }
    }
}

