namespace SACDA喷涂项目
{
    partial class UserDeviceUnitControl
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
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            sw_Device = new Sunny.UI.UISwitch();
            lbl_Device = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            uiTableLayoutPanel1.Controls.Add(sw_Device, 1, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_Device, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 3;
            uiTableLayoutPanel1.TagString = null;
            // 
            // sw_Device
            // 
            sw_Device.BackColor = Color.FromArgb(243, 249, 255);
            sw_Device.Dock = DockStyle.Fill;
            sw_Device.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sw_Device.Location = new Point(133, 3);
            sw_Device.MinimumSize = new Size(1, 1);
            sw_Device.Name = "sw_Device";
            sw_Device.Size = new Size(114, 54);
            sw_Device.TabIndex = 1;
            sw_Device.Text = "uiSwitch1";
            sw_Device.Click += sw_Device_Click;
            // 
            // lbl_Device
            // 
            lbl_Device.Dock = DockStyle.Fill;
            lbl_Device.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Device.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Device.Location = new Point(3, 0);
            lbl_Device.Name = "lbl_Device";
            lbl_Device.Size = new Size(124, 60);
            lbl_Device.TabIndex = 2;
            lbl_Device.Text = "设备开关";
            lbl_Device.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserDeviceUnitControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(uiTableLayoutPanel1);
            FillColor = Color.Transparent;
            Name = "UserDeviceUnitControl";
            RectColor = Color.Transparent;
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UISwitch sw_Device;
        private Sunny.UI.UILabel lbl_Device;
    }
}
