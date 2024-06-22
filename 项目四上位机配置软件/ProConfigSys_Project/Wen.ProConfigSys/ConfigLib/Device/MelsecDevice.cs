using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConfigLib
{
    public enum MelsecType
    {
        FX3U,
        FX5U,
        Q
    }

    public class MelsecDevice : DeviceBase
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
        /// Э������
        /// </summary>
        public string ProtocolType { get; set; }

        /// <summary>
        /// ����CPU����
        /// </summary>
        public MelsecType MelsecType { get; set; } = MelsecType.Q;


        /// <summary>
        /// ͨ���鼯��
        /// </summary>
        public List<MelsecGroup> GroupList { get; set; } = new List<MelsecGroup>();

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
                    //�Ƿ�鵵
                    if (variable.ArchiveEnable)
                    {
                        StoreVarList.Add(variable);
                    }
                    //���б���ֵ�ļ���
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
