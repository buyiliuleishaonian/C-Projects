using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    public class EquipmentsModel
    {
        /// <summary>
        /// ���
        /// </summary>
        public int SN { get; set; }
        /// <summary>
        /// �豸���
        /// </summary>
        public int Equipmentid { get; set; }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public int Projectid { get; set; }
        /// <summary>
        /// �豸����ID
        /// </summary>
        public int Etypeid { get; set; }
        /// <summary>
        /// Э������ID
        /// </summary>
        public int Ptypeid { get; set; }
        /// <summary>
        /// �豸����
        /// </summary>
        public string EquipmentName { get; set; }

        //��������Ϊѡ���֣�����Ҫ��Ĭ��ֵ
        //������趨�����ǿն���

        /// <summary>
        /// IP��ַ
        /// </summary>
        public string Ipaddress { get; set; } = string.Empty;
        /// <summary>
        /// �˿ں�
        /// </summary>
        public string Portno { get; set; } = string.Empty;
        /// <summary>
        /// ��վ��
        /// </summary>
        public string Seriablno { get; set; }= string.Empty;
        /// <summary>
        /// ������
        /// </summary>
        public int Baudrate { get; set; } = 0;
        /// <summary>
        /// ����λ
        /// </summary>
        public int Databit { get; set; } = 0;
        /// <summary>
        /// У��λ
        /// </summary>
        public string Paritybit { get; set; } = string.Empty;
        /// <summary>
        /// ֹͣλ
        /// </summary>
        public int Stopbit { get; set; } = 0;
        /// <summary>
        /// OPC�ڵ�����
        /// </summary>
        public string Opcnodename { get; set; } = string.Empty;
        /// <summary>
        /// OPC����������
        /// </summary>
        public string Opcservername { get; set; } = string.Empty;
        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public int Isenable { get; set; } = 0;
        /// ��ע
        /// </summary>
        public string Comments { get; set; } = string.Empty;


        //������趨���Ӧ����չ����
        /// <summary>
        /// �豸����
        /// </summary>
        public string EtypeName { get; set; }

        /// <summary>
        /// Э��������
        /// </summary>
        public string PtypeName { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ProjectName { get; set; }
    }
}

