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
    public partial class userDeviceAlarmState : UIUserControl
    {
        public userDeviceAlarmState()
        {
            InitializeComponent();
        }

        private string deviceRunName;

        [Category("自定义")]
        [Browsable(true)]
        [Description("控件文本")]
        public string DeviceRunName
        {
            get { return deviceRunName; }
            set
            {
                deviceRunName = value;
                this.lbl_AlarmText.Text = deviceRunName;
            }
        }

        [Category("自定义")]
        [Browsable(true)]
        [Description("变量名")]
        public string VariableName { get; set; }


        private bool state;


        [Category("自定义")]
        [Browsable(true)]
        [Description("变量值")]
        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (state == true)
                {
                    this.lbl_Alarm.SymbolColor =Color.LimeGreen ;
                }
                else
                {
                    this.lbl_Alarm.SymbolColor = Color.Red;
                }
            }
        }
    }
}
