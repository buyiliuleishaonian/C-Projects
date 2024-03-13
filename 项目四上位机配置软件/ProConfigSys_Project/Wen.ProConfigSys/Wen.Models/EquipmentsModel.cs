using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    public class EquipmentsModel
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int SN { get; set; }
        /// <summary>
        /// 设备序号
        /// </summary>
        public int Equipmentid { get; set; }
        /// <summary>
        /// 项目ID
        /// </summary>
        public int Projectid { get; set; }
        /// <summary>
        /// 设备类型ID
        /// </summary>
        public int Etypeid { get; set; }
        /// <summary>
        /// 协议类型ID
        /// </summary>
        public int Ptypeid { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName { get; set; }

        //以下内容为选填现，所以要给默认值
        //如果不设定，就是空对象

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ipaddress { get; set; } = string.Empty;
        /// <summary>
        /// 端口号
        /// </summary>
        public string Portno { get; set; } = string.Empty;
        /// <summary>
        /// 从站号
        /// </summary>
        public string Seriablno { get; set; }= string.Empty;
        /// <summary>
        /// 波特率
        /// </summary>
        public int Baudrate { get; set; } = 0;
        /// <summary>
        /// 数据位
        /// </summary>
        public int Databit { get; set; } = 0;
        /// <summary>
        /// 校验位
        /// </summary>
        public string Paritybit { get; set; } = string.Empty;
        /// <summary>
        /// 停止位
        /// </summary>
        public int Stopbit { get; set; } = 0;
        /// <summary>
        /// OPC节点名称
        /// </summary>
        public string Opcnodename { get; set; } = string.Empty;
        /// <summary>
        /// OPC服务器名称
        /// </summary>
        public string Opcservername { get; set; } = string.Empty;
        /// <summary>
        /// 是否启用
        /// </summary>
        public int Isenable { get; set; } = 0;
        /// 备注
        /// </summary>
        public string Comments { get; set; } = string.Empty;


        //给外键设定相对应的扩展属性
        /// <summary>
        /// 设备名称
        /// </summary>
        public string EtypeName { get; set; }

        /// <summary>
        /// 协议类型名
        /// </summary>
        public string PtypeName { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }
    }
}

