namespace SACDA喷涂项目
{
    partial class UserDeviceState
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
            lgh_State = new Sunny.UI.UILight();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_Equipment = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lgh_State
            // 
            lgh_State.BackColor = Color.Transparent;
            lgh_State.Dock = DockStyle.Fill;
            lgh_State.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lgh_State.ForeColor = Color.Transparent;
            lgh_State.Location = new Point(193, 3);
            lgh_State.MinimumSize = new Size(1, 1);
            lgh_State.Name = "lgh_State";
            lgh_State.OffColor = Color.Red;
            lgh_State.OnColor = Color.Lime;
            lgh_State.Radius = 54;
            lgh_State.Size = new Size(54, 54);
            lgh_State.TabIndex = 1;
            lgh_State.Text = "uiLight1";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(lgh_State, 1, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_Equipment, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 2;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_Equipment
            // 
            lbl_Equipment.Dock = DockStyle.Fill;
            lbl_Equipment.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Equipment.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Equipment.Location = new Point(3, 0);
            lbl_Equipment.Name = "lbl_Equipment";
            lbl_Equipment.Size = new Size(184, 60);
            lbl_Equipment.TabIndex = 2;
            lbl_Equipment.Text = "工位状态";
            lbl_Equipment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserDeviceState
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(uiTableLayoutPanel1);
            FillColor = Color.Transparent;
            ForeColor = Color.Transparent;
            Name = "UserDeviceState";
            RectColor = Color.Transparent;
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILight lgh_State;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel lbl_Equipment;
    }
}
