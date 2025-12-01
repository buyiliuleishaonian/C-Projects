namespace SACDA喷涂项目
{
    partial class UserControlButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            btn = new Sunny.UI.UISymbolButton();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Dock = DockStyle.Fill;
            btn.Font = new Font("微软雅黑", 21.75F);
            btn.Location = new Point(0, 0);
            btn.MinimumSize = new Size(1, 1);
            btn.Name = "btn";
            btn.Size = new Size(190, 50);
            btn.Symbol = 558653;
            btn.SymbolSize = 55;
            btn.TabIndex = 0;
            btn.Text = "空运行";
            btn.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn.Click += btn_Click;
            // 
            // UserControlButton
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(btn);
            FillColor = Color.Transparent;
            Name = "UserControlButton";
            RectColor = Color.Transparent;
            Size = new Size(190, 50);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISymbolButton btn;
    }
}
