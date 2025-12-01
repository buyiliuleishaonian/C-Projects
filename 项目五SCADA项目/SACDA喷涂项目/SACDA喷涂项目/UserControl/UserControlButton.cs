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
    [DefaultEvent("ButtonClick")]
    public partial class UserControlButton : UIUserControl
    {
        public UIStyle Style;
        public Color fillColot;
        public Color rectColot;
        public UserControlButton()
        {
            InitializeComponent();

            this.Load += UserControlButton_Load;
        }

        /// <summary>
        /// 调用主题委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void UserControlButton_Load(object? sender, EventArgs e)
        {
            UIExtonsion.SetStyleManagerDelegate = SetStyle;
        }

        private void SetStyle(UIStyleManager manager)
        {
            this.btn.Style = manager.Style;
            fillColor = this.btn.FillColor;
            rectColor = this.btn.RectColor;
        }

        private int countButtonSymbol = 558653;
        [Category("自定义")]
        [Description("字体图标")]
        [Browsable(true)]
        public int CountButtonSymbol

        {
            get { return countButtonSymbol; ; }
            set
            {
                countButtonSymbol = value;
                this.btn.Symbol = countButtonSymbol;
            }
        }


        private string countButtonText;
        [Category("自定义")]
        [Description("文本名称")]
        [Browsable(true)]
        public string CountButtonText
        {
            get { return countButtonText; }
            set
            {
                countButtonText = value;
                this.btn.Text = countButtonText;
            }
        }

        private string variableName;
        [Category("自定义")]
        [Description("绑定的变量名称")]
        [Browsable(true)]

        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }

        private bool countButtonStyle;

        private void btn_Click(object sender, EventArgs e)
        {
            if (ButtonClick!=null)
            {
                ButtonClick.Invoke(this, e);
            }
        }

        [Category("自定义")]
        [Description("按钮状态")]
        [Browsable(true)]
        public bool CountButtonStyle
        {
            get { return countButtonStyle; }
            set
            {
                countButtonStyle = value;
                if (countButtonStyle)
                {
                    this.btn.FillColor = this.btn.FillPressColor;
                    this.btn.RectColor = this.btn.RectPressColor;
                }
                else
                {
                    if (this.btn.Style == Style)
                    {
                        this.btn.FillColor = fillColor;
                        this.btn.RectColor = rectColor;
                    }
                    else
                    {
                        this.btn.Style = Style;
                    }
                }
            }
        }

        public event EventHandler ButtonClick;


    }
}
