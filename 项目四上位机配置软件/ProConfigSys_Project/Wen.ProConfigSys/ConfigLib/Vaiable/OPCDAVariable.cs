using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   ConfigLib
{
    /// <summary>
    /// OPCDAͨ��
    /// </summary>
    public  class OPCDAVariable: VariableBase
    {
        /// <summary>
        /// �������
        /// </summary>
        [JsonIgnore]
        public int ClientHandle { get; set; }

        /// <summary>
        /// ����ͨ������
        /// </summary>
        [JsonIgnore]
        public int GroupHandle { get; set; }

    }
}
