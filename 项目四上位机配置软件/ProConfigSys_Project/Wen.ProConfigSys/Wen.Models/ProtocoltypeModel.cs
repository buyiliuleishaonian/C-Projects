using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wen.Models
{
    /// <summary>
    /// Э��������
    /// </summary>
    public class ProtocoltypeModel
    {
        /// <summary>
        /// Э��ID
        /// </summary>
        public int PtypeId { get; set; }
        /// <summary>
        /// �豸����
        /// </summary>
        public int Etypeid { get; set; }
        /// <summary>
        /// Э������
        /// </summary>
        public string Ptypename { get; set; }

        //��չ�������
        public string EtypeName { get; set; }
    }
}

