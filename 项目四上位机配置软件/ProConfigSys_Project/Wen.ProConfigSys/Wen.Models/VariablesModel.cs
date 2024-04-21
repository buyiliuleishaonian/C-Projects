using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    /// <summary>
    /// 变量类
    /// </summary>
    public class VariablesModel
    {

        public int SN { get; set; }
        /// <summary>
        /// 变量ID
        /// </summary>
        public int Variableid { get; set; }
        /// <summary>
        /// 变量名
        /// </summary>
        public string Variablename { get; set; }
        /// <summary>
        /// 通信组ID
        /// </summary>
        public int Cgid { get; set; }
        /// <summary>
        /// 开始地址
        /// </summary>
        public string Startaddress { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string Datatype { get; set; } 
        /// <summary>
        /// 是否启用最大值报警
        /// </summary>
        public bool Ismaxalarm { get; set; } = false;
        /// <summary>
        /// 是否启用最小值报警
        /// </summary>
        public bool Isminalarm { get; set; } = false;
        /// <summary>
        /// 最大值
        /// </summary>
        public string Alarmmax { get; set; }
        /// <summary>
        /// 最小值
        /// </summary>
        public string Alarmmin { get; set; }
        /// <summary>
        /// 是否归档
        /// </summary>
        public bool Isfile { get; set; }

        /// <summary>
        /// 上限报警说明
        /// </summary>
        public string AlarmMaxNode { get; set; }

        /// <summary>
        /// 下限报警说明
        /// </summary>
        public string AlarmMinNode {  get; set; }

        /// <summary>
        /// 线性系数
        /// </summary>
        public string Scale { get; set; }

        /// <summary>
        /// 偏移量/长度
        /// </summary>
        public string Offsetorlength { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }


    }
}

