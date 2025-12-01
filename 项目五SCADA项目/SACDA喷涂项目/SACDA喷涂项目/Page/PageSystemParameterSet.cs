using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACDA喷涂项目
{
    public partial class PageSystemParameterSet : UIPage, ISingletonSelfDependency
    {
        public PageSystemParameterSet()
        {
            InitializeComponent();

            this.Load += PageSystemParameterSet_Load;
        }

        private void PageSystemParameterSet_Load(object? sender, EventArgs e)
        {
            InitLoad();
        }

        private void InitLoad()
        {
            this.txt_PLCConfigPath.Text = Global.PLCInipath;
            this.txt_IP.Text = Global.IP;
            this.txt_CPU.Text = Global.CPUtype.ToString();
            this.txt_Port.Text = Global.Port.ToString();
            this.txt_Rack.Text = Global.Rack.ToString();
            this.txt_Slot.Text = Global.Slot.ToString();
            this.txt_ReadTimeIntelVAL.Text = Global.ReadTimeInterval.ToString();
            this.txt_ConnectTimeOut.Text = Global.ConnectTimeout.ToString();
            this.txt_ReConnectTimeInterval.Text = Global.ReConnectTimeInterval.ToString();
        }


        /// <summary>
        /// 保存对ini配置文件的修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Global.IniFile.Write("PLC参数", "PLC地址", this.txt_PLCConfigPath.Text);
            Global.IniFile.Write("PLC参数", "cpu类型", this.txt_CPU.Text);
            Global.IniFile.Write("PLC参数", "IP地址", this.txt_IP.Text);
            Global.IniFile.Write("PLC参数", "端口号", this.txt_Port.Text);
            Global.IniFile.Write("PLC参数", "槽口号", this.txt_Slot.Text);
            Global.IniFile.Write("PLC参数", "机架号", this.txt_Rack.Text);
            Global.IniFile.Write("PLC参数", "读取超时时间", this.txt_ConnectTimeOut.Text);
            Global.IniFile.Write("PLC参数", "重连超时时间", this.txt_ReConnectTimeInterval.Text);
            Global.IniFile.Write("PLC参数", "连接超时", this.txt_ReadTimeIntelVAL.Text);

        }
    }
}
