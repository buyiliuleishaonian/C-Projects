using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using Newtonsoft.Json;

namespace ConfigLib
{
    public class ModbusASCIIDevice : DeviceBase
    {
        /// <summary>
        /// �˿ں�
        /// </summary>
        public string PortName { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public int Baudrate { get; set; }

        /// <summary>
        /// У��λ
        /// </summary>
        public Parity Parity { get; set; }

        /// <summary>
        /// ����λ
        /// </summary>
        public int Databits { get; set; }

        /// <summary>
        /// ֹͣλ
        /// </summary>
        public StopBits Stopbits  { get; set; }

        /// <summary>
        /// �Ƿ�Ϊ�̵�ַ
        /// </summary>
        public bool IsShortAddress { get; set; }

        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<ModbusASCIIGroup> GroupList { get; set; } = new List<ModbusASCIIGroup>();

        
        /// <summary>
        /// ѭ������
        /// </summary>
        [JsonIgnore]
        public int CycleTimes { get; set; }

        /// <summary>
        /// ����ѭ������
        /// </summary>
        [JsonIgnore]
        public int CheckCycleTimes { get; set; } = 10;


        /// <summary>
        /// ������ʼ��
        /// </summary>
        public void Init()
        {
            foreach (var gp in GroupList)
            {
                foreach (var variable in gp.VarList)
                {
                    VarList.Add(variable);

                    if (variable.ArchiveEnable)
                    {
                        StoreVarList.Add(variable);
                    }

                    if (CurrentValue.ContainsKey(variable.VarName))
                    {
                        CurrentValue[variable.VarName] = "NA";
                    }
                    else
                    {
                        CurrentValue.Add(variable.VarName, "NA");
                    }
                }
            }
        }
    }
}
