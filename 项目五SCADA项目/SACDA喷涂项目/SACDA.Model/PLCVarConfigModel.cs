using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACDA.Model
{
    public class PLCVarConfigModel
    {
        /// <summary>
        /// 模块
        /// </summary>
        public string 所属模块 { get; set; }

        /// <summary>
        /// 变量名称
        /// </summary>
        public string 名称 { get; set; }

        /// <summary>
        /// 变量地址
        /// </summary>
        public string PLC地址 { get; set; }

        /// <summary>
        /// 变量数据类型
        /// </summary>
        public string 变量类型 { get; set; }

        /// <summary>
        /// 是否保存
        /// </summary>
        public bool 是否保存 { get; set; }
    }
}
