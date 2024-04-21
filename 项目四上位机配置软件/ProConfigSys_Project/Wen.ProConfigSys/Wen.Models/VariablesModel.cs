using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Models
{
    /// <summary>
    /// ������
    /// </summary>
    public class VariablesModel
    {

        public int SN { get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public int Variableid { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string Variablename { get; set; }
        /// <summary>
        /// ͨ����ID
        /// </summary>
        public int Cgid { get; set; }
        /// <summary>
        /// ��ʼ��ַ
        /// </summary>
        public string Startaddress { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string Datatype { get; set; } 
        /// <summary>
        /// �Ƿ��������ֵ����
        /// </summary>
        public bool Ismaxalarm { get; set; } = false;
        /// <summary>
        /// �Ƿ�������Сֵ����
        /// </summary>
        public bool Isminalarm { get; set; } = false;
        /// <summary>
        /// ���ֵ
        /// </summary>
        public string Alarmmax { get; set; }
        /// <summary>
        /// ��Сֵ
        /// </summary>
        public string Alarmmin { get; set; }
        /// <summary>
        /// �Ƿ�鵵
        /// </summary>
        public bool Isfile { get; set; }

        /// <summary>
        /// ���ޱ���˵��
        /// </summary>
        public string AlarmMaxNode { get; set; }

        /// <summary>
        /// ���ޱ���˵��
        /// </summary>
        public string AlarmMinNode {  get; set; }

        /// <summary>
        /// ����ϵ��
        /// </summary>
        public string Scale { get; set; }

        /// <summary>
        /// ƫ����/����
        /// </summary>
        public string Offsetorlength { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Comments { get; set; }


    }
}

