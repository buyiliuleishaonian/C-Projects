namespace SACDA喷涂项目
{
    partial class UserSetValue
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
            lbl_unit = new Sunny.UI.UILabel();
            txt_Value = new Sunny.UI.UITextBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_varibale = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_unit
            // 
            lbl_unit.BackColor = Color.Transparent;
            lbl_unit.Dock = DockStyle.Fill;
            lbl_unit.Font = new Font("宋体", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_unit.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_unit.Location = new Point(270, 0);
            lbl_unit.Name = "lbl_unit";
            lbl_unit.Size = new Size(64, 46);
            lbl_unit.TabIndex = 2;
            lbl_unit.Text = "s";
            lbl_unit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Value
            // 
            txt_Value.AutoSize = true;
            txt_Value.Dock = DockStyle.Fill;
            txt_Value.DoubleValue = 22D;
            txt_Value.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Value.IntValue = 22;
            txt_Value.Location = new Point(171, 5);
            txt_Value.Margin = new Padding(4, 5, 4, 5);
            txt_Value.MinimumSize = new Size(1, 16);
            txt_Value.Name = "txt_Value";
            txt_Value.Padding = new Padding(5);
            txt_Value.RectColor = Color.Transparent;
            txt_Value.ShowText = false;
            txt_Value.Size = new Size(92, 36);
            txt_Value.TabIndex = 3;
            txt_Value.Text = "22";
            txt_Value.TextAlignment = ContentAlignment.MiddleCenter;
            txt_Value.Watermark = "";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 3;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            uiTableLayoutPanel1.Controls.Add(lbl_unit, 2, 0);
            uiTableLayoutPanel1.Controls.Add(txt_Value, 1, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_varibale, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(337, 46);
            uiTableLayoutPanel1.TabIndex = 4;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_varibale
            // 
            lbl_varibale.Dock = DockStyle.Fill;
            lbl_varibale.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_varibale.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_varibale.Location = new Point(3, 0);
            lbl_varibale.Name = "lbl_varibale";
            lbl_varibale.Size = new Size(161, 46);
            lbl_varibale.TabIndex = 4;
            lbl_varibale.Text = "变量";
            lbl_varibale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserSetValue
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(uiTableLayoutPanel1);
            FillColor = Color.Transparent;
            Name = "UserSetValue";
            RectColor = Color.Transparent;
            Size = new Size(337, 46);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lbl_unit;
        private Sunny.UI.UITextBox txt_Value;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel lbl_varibale;
    }
}
