using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   ConfigLib
{
    public  class OmronGroup : GroupBase
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
        public List<OmronVariable> VarList { get; set; } = new List<OmronVariable>();

    }
}
