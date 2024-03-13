using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    /// <summary>
    /// ͨ�������
    /// </summary>
    public class CommunicationsgroupsModel
    {
        /// <summary>
        /// ���
        /// </summary>
        public int SN { get; set; }
        /// <summary>
        /// ͨ�������
        /// </summary>
        public int Cgid { get; set; }
        /// <summary>
        /// �豸����ID
        /// </summary>
        public int Equipmentid { get; set; }
        /// <summary>
        /// ͨ��������
        /// </summary>
        public string Cgname { get; set; }
        /// <summary>
        /// ��ʼ��ַ
        /// </summary>
        public string Startaddress { get; set; }
        /// <summary>
        /// ͨ���鳤��
        /// </summary>
        public int Cglength { get; set; }
        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public int Isenable { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Comments { get; set; }

        //��չ����
        /// <summary>
        /// �豸��������
        /// </summary>
        public string EquipmentName { get; set; }
    }
}

