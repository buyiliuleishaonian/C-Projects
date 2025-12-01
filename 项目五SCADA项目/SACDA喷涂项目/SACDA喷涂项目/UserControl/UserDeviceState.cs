using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACDA喷涂项目
{
    public partial class UserDeviceState : UIUserControl
    {
        public UserDeviceState()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            
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
                this.lbl_Equipment.Text = deviceRunName;
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
                    this.lgh_State.State = UILightState.On;
                }
                else
                {
                    this.lgh_State.State = UILightState.Off;
                }
            }
        }
    }
}
