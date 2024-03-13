using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    /// <summary>
    /// 通信组对象
    /// </summary>
    public class CommunicationsgroupsModel
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int SN { get; set; }
        /// <summary>
        /// 通信组序号
        /// </summary>
        public int Cgid { get; set; }
        /// <summary>
        /// 设备类型ID
        /// </summary>
        public int Equipmentid { get; set; }
        /// <summary>
        /// 通信组名称
        /// </summary>
        public string Cgname { get; set; }
        /// <summary>
        /// 起始地址
        /// </summary>
        public string Startaddress { get; set; }
        /// <summary>
        /// 通信组长度
        /// </summary>
        public int Cglength { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int Isenable { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }

        //扩展属性
        /// <summary>
        /// 设备类型名称
        /// </summary>
        public string EquipmentName { get; set; }
    }
}

