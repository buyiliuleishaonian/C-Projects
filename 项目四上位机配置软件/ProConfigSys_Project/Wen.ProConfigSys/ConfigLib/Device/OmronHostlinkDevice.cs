using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

namespace ConfigLib
{
    public class OmronHostlinkDevice : DeviceBase
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
        /// ��Ԫ��
        /// </summary>
        public byte UnitNo { get; set; }

        /// <summary>
        /// PC��Ԫ��
        /// </summary>
        public byte SA2 { get; set; }

        /// <summary>
        /// �ȴ���Ӧʱ��
        /// </summary>
        public byte ResponseWaitTime { get; set; }

        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<OmronHostlinkGroup> GroupList { get; set; } = new List<OmronHostlinkGroup>();

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
