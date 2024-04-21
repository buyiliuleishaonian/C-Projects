using MTHModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wen.ControlLib
{
    public partial class RecipeControl : UserControl
    {
        public RecipeControl()
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

        private string title = "1#站点";
        [Browsable(true)]
        [Category("自定义")]
        [Description("设定或获取控件的抬头")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.titleControl1.TitleName = value;
                this.textSetEX1.TitleName=title+"温度高限";
                this.textSetEX2.TitleName=title+"温度低限";
                this.textSetEX3.TitleName=title+"湿度高限";
                this.textSetEX4.TitleName=title+"湿度低限";
            }
        }

        //添加一下配方管理的类对象
        private RecipeParam recipeParam = new RecipeParam();
        [Browsable(false)]

        /// <summary>
        /// 将值更新到界面，也可以通过界面得到值
        /// 也可以通过代码得到值
        /// </summary>
        /// <returns></returns>
        public RecipeParam RecipeParam 
        {
            get {
                recipeParam=GetRecipeParam();
                return recipeParam; }
            set { recipeParam=value;    
                SetRecipeParam(recipeParam);
            }
        }

        /// <summary>
        /// 得到一个RecipeParam对象
        /// </summary>
        /// <returns></returns>
        private RecipeParam GetRecipeParam()
        {
            return new RecipeParam()
            {
                //将窗体的值返回给RecipeParam对象
                TempHight= this.textSetEX1.CurrentValue,
                TempLow=this.textSetEX2.CurrentValue,
                HumidityHight=this.textSetEX3.CurrentValue,
                HumidityLow=this.textSetEX4.CurrentValue,
                TempAlarmEnalbe=this.checkBoxEX1.Checked,
                HumidityEnalbe=this.checkBoxEX2.Checked,
            };
        }

        /// <summary>
        /// 设定一个RecipeParam对象
        /// </summary>
        /// <returns></returns>
        private void SetRecipeParam(RecipeParam rp)
        {
            //将RecipeParam对象的值赋值给窗体
            this.textSetEX1.CurrentValue = rp.TempHight;
            this.textSetEX2.CurrentValue = rp.TempLow;
            this.textSetEX3.CurrentValue=rp.HumidityHight;
            this.textSetEX4.CurrentValue=recipeParam.HumidityLow;
            this.checkBoxEX1.Checked=rp.TempAlarmEnalbe;
            this.checkBoxEX2.Checked=rp.HumidityEnalbe;
        }
    }
}
