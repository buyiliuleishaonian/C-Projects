using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLib
{
    public  class GroupBase
    {
        /// <summary>
        /// ͨ���������
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// ͨ�����Ƿ񼤻�
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [JsonIgnore]
        public int ErrorTimes { get; set; }

        /// <summary>
        /// �ݴ����
        /// </summary>
        [JsonIgnore]
        public int AllowErrorTimes { get; set; } = 3;

        /// <summary>
        /// ͨ�Ž��
        /// </summary>
        [JsonIgnore]
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// �ɼ�ʱ��
        /// </summary>
        [JsonIgnore]
        public string AcquisitionTime { get; set; }


    }
}
