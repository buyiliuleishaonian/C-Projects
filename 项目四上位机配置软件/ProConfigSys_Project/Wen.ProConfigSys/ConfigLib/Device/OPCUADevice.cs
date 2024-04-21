using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigLib
{

    public class OPCUADevice : DeviceBase
    {
        /// <summary>
        /// ������URL��ַ
        /// </summary>
        public string ServerUrl { get; set; }


        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<OPCUAGroup> GroupList { get; set; } = new List<OPCUAGroup>();

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
