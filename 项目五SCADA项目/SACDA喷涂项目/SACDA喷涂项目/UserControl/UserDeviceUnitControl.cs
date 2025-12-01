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
    [DefaultEvent("ChangeClick")]
    public partial class UserDeviceUnitControl : UIUserControl
    {
        public UserDeviceUnitControl()
        {
            InitializeComponent();

            //提高绘制的性能，因为只在需要时才重绘控件。
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //双缓冲绘制可以减少闪烁和绘制的不连贯，通过在后台绘制控件，
            //然后一次性将整个绘制结果显示在屏幕上，提高了绘制的平滑性和视觉效果
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            //确保控件会在大小调整后进行重绘，以适应新的大小
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //这一行表明控件可以被选中
            this.SetStyle(ControlStyles.Selectable, true);
            //这一行表明控件支持透明的背景色
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }


        private string equipmentUnitName;


        [Category("自定义")]
        [Browsable(true)]
        public string EquipmentUnitName
        {
            get { return equipmentUnitName; }
            set
            {
                equipmentUnitName = value;
                this.lbl_Device.Text = equipmentUnitName;
            }
        }

        [Category("自定义")]
        [Browsable(true)]
        public string OpenVariableName { get; set; }

        [Category("自定义")]
        [Browsable(true)]
        public string CloseVariableName { get; set; }

        [Category("自定义")]
        [Browsable(true)]
        [Description("当开关变换时，触发该事件")]
        public event EventHandler ClickEvent;

        
        private void sw_Device_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }
        private bool state;

        [Description("变量状态")]
        [Category("自定义")]
        [Browsable(true)]
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                this.sw_Device.Active = state;
            }
        }

    }
}
