using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLib
{
    public  class SiemensDevice:DeviceBase
    {
        /// <summary>
        /// IP��ַ
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// �˿ں�
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// CPU����
        /// </summary>
        public string CPUType { get; set; }

        /// <summary>
        /// ���ܺ�
        /// </summary>
        public int Rack { get; set; }

        /// <summary>
        /// ��ۺ�
        /// </summary>
        public int Slot { get; set; }

        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<SiemensGroup> GroupList { get; set; } = new List<SiemensGroup>();

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
