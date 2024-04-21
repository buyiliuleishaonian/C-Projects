using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   ConfigLib
{
    public  class Project
    {
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// �������豸����
        /// </summary>
        public List<SiemensDevice> SiemensList { get; set; } = new List<SiemensDevice>();

        /// <summary>
        /// �����豸����
        /// </summary>
        public List<MelsecDevice> MelsecList { get; set; } = new List<MelsecDevice>();

        public List<MelsecFXSerialDevice> MelsecFXSerialList { get; set; } = new List<MelsecFXSerialDevice>();

        /// <summary>
        /// ŷķ���豸����
        /// </summary>
        public List<OmronDevice> OmronList { get; set; } = new List<OmronDevice>();

        public List<OmronHostlinkDevice> OmronHostlinkList { get; set; } = new List<OmronHostlinkDevice>();
        /// <summary>
        /// ModbusRTU�豸����
        /// </summary>
        public List<ModbusRTUDevice> ModbusRTUList { get; set; } = new List<ModbusRTUDevice>();

        /// <summary>
        /// ModbusASCII�豸����
        /// </summary>
        public List<ModbusASCIIDevice> ModbusASCIIList { get; set; } = new List<ModbusASCIIDevice>();

        /// <summary>
        /// ModbusTCP�豸����
        /// </summary>
        public List<ModbusTCPDevice> ModbusTCPList { get; set; } = new List<ModbusTCPDevice>();


        /// <summary>
        /// ModbusRTUOverTCP�豸����
        /// </summary>
        public List<ModbusRTUOverTCPDevice> ModbusRTUOverTCPList { get; set; } = new List<ModbusRTUOverTCPDevice>();


        /// <summary>
        /// OPCDA�豸����
        /// </summary>
        public List<OPCDADevice> OPCDAList { get; set; } = new List<OPCDADevice>();


        /// <summary>
        /// OPCUA�豸����
        /// </summary>
        public List<OPCUADevice> OPCUAList { get; set; } = new List<OPCUADevice>();

    }
}
