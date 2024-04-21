using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   ConfigLib
{
    public  class OPCDAGroup : GroupBase
    {
        /// <summary>
        /// ͨ������
        /// </summary>
        [JsonIgnore]
        public int ClientHandle { get; set; }

        /// <summary>
        /// �����ļ���
        /// </summary>
        public List<OPCDAVariable> VarList { get; set; } = new List<OPCDAVariable>();

    }
}
