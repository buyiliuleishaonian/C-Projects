using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   ConfigLib
{
    /// <summary>
    /// ͨ�ñ�����
    /// </summary>
    public  class VariableBase
    {
        /// <summary>
        /// ��������
        /// </summary>
        public string VarName { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string VarType { get; set; }

        /// <summary>
        /// ������ַ
        /// </summary>
        public string VarAddress { get; set; }

        /// <summary>
        /// ������ֵ
        /// </summary>
        [JsonIgnore]
        public object VarValue { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// ���Ա���ϵ��
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// ƫ����
        /// </summary>
        public float Offset { get; set; }

        /// <summary>
        /// �Ƿ�鵵
        /// </summary>
        public bool ArchiveEnable { get; set; }

        /// <summary>
        /// �߱�������
        /// </summary>
        public bool HighAlarmEnable { get; set; }

        /// <summary>
        /// �߱����趨ֵ
        /// </summary>
        public float HighAlarmValue { get; set; }

        /// <summary>
        /// �߱���˵��
        /// </summary>
        public string HighAlarmNote { get; set; }

        /// <summary>
        /// �߱�������ֵ
        /// </summary>
        [JsonIgnore]
        public float HighAlarmCacheValue { get; set; }



        /// <summary>
        /// �ͱ�������
        /// </summary>
        public bool LowAlarmEnable { get; set; }

        /// <summary>
        /// �ͱ����趨ֵ
        /// </summary>
        public float LowAlarmValue { get; set; }

        /// <summary>
        /// �ͱ���˵��
        /// </summary>
        public string LowAlarmNote { get; set; }

        /// <summary>
        /// �ͱ�������ֵ
        /// </summary>
        [JsonIgnore]
        public float LowAlarmCacheValue { get; set; }

    }
}
