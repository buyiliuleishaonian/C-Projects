using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ConfigLib
{
    public  class ModbusASCIIGroup : GroupBase
    {
        /// <summary>
        /// ��ʼ��ַ
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// �����ļ���
        /// </summary>
        public List<ModbusASCIIVariable> VarList { get; set; } = new List<ModbusASCIIVariable>();

    }
}
