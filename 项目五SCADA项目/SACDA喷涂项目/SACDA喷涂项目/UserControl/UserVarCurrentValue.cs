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
    public partial class UserVarCurrentValue : UIUserControl
    {
        public UserVarCurrentValue()
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


        private string deviceName;


        [Category("自定义")]
        [Browsable(true)]
        [Description("控件名称")]
        public string DeviceName
        {
            get { return deviceName; }
            set
            {
                deviceName = value;
                this.lbl_var.Text = deviceName;
            }
        }


        private string variableName;

        [Description("变量名")]
        [Browsable(true)]
        [Category("自定义")]
        public string VariableName
        {
            get { return variableName; }
            set
            {
                variableName = value;
            }
        }




        private string unit;

        [Category("自定义")]
        [Description("单位名称")]
        [Browsable(true)]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.uiLabel1.Text = unit;
            }
        }

        private string varValue;
        [Category("自定义")]
        [Description("变量值")]
        [Browsable(true)]
        public string VarValue
        {
            get { return varValue; }
            set
            {
                varValue = value;
               this.lbl_varCurrent.Text=varValue;
            }
        }

    }
}
