using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLib
{

    public class ModbusTCPDevice : DeviceBase
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
        /// �Ƿ�Ϊ�̵�ַ
        /// </summary>
        public bool IsShortAddress { get; set; }


        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<ModbusTCPGroup> GroupList { get; set; } = new List<ModbusTCPGroup>();

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
