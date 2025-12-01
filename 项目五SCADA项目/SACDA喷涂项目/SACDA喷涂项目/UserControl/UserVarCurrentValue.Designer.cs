namespace SACDA喷涂项目
{
    partial class UserVarCurrentValue
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
            uiLabel1 = new Sunny.UI.UILabel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_varCurrent = new Sunny.UI.UIDigitalLabel();
            lbl_var = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Dock = DockStyle.Fill;
            uiLabel1.Font = new Font("宋体", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(265, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(69, 60);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "s";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = Color.Transparent;
            uiTableLayoutPanel1.ColumnCount = 3;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 2, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_varCurrent, 1, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_var, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(337, 60);
            uiTableLayoutPanel1.TabIndex = 4;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_varCurrent
            // 
            lbl_varCurrent.BackColor = Color.Transparent;
            lbl_varCurrent.Dock = DockStyle.Fill;
            lbl_varCurrent.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_varCurrent.ForeColor = Color.Cyan;
            lbl_varCurrent.Location = new Point(140, 3);
            lbl_varCurrent.MinimumSize = new Size(1, 1);
            lbl_varCurrent.Name = "lbl_varCurrent";
            lbl_varCurrent.Size = new Size(119, 54);
            lbl_varCurrent.TabIndex = 3;
            lbl_varCurrent.Text = "uiDigitalLabel1";
            lbl_varCurrent.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_var
            // 
            lbl_var.BackColor = Color.Transparent;
            lbl_var.Dock = DockStyle.Fill;
            lbl_var.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_var.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_var.Location = new Point(3, 0);
            lbl_var.Name = "lbl_var";
            lbl_var.Size = new Size(131, 60);
            lbl_var.TabIndex = 4;
            lbl_var.Text = "变量";
            lbl_var.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserVarCurrentValue
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(uiTableLayoutPanel1);
            FillColor = Color.Transparent;
            Name = "UserVarCurrentValue";
            RectColor = Color.Transparent;
            Size = new Size(337, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIDigitalLabel lbl_varCurrent;
        private Sunny.UI.UILabel lbl_var;
    }
}
