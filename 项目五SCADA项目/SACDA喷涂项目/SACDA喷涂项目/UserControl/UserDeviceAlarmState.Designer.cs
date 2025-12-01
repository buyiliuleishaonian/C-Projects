namespace SACDA喷涂项目
{
    partial class userDeviceAlarmState
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
            lbl_Alarm = new Sunny.UI.UISymbolLabel();
            lbl_AlarmText = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(lbl_Alarm, 1, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_AlarmText, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.ForeColor = Color.Transparent;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 1;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_Alarm
            // 
            lbl_Alarm.Dock = DockStyle.Fill;
            lbl_Alarm.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Alarm.Location = new Point(193, 3);
            lbl_Alarm.MinimumSize = new Size(1, 1);
            lbl_Alarm.Name = "lbl_Alarm";
            lbl_Alarm.Size = new Size(54, 54);
            lbl_Alarm.Symbol = 61683;
            lbl_Alarm.SymbolColor = Color.Red;
            lbl_Alarm.SymbolSize = 54;
            lbl_Alarm.TabIndex = 1;
            // 
            // lbl_AlarmText
            // 
            lbl_AlarmText.Dock = DockStyle.Fill;
            lbl_AlarmText.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_AlarmText.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_AlarmText.Location = new Point(3, 0);
            lbl_AlarmText.Name = "lbl_AlarmText";
            lbl_AlarmText.Size = new Size(184, 60);
            lbl_AlarmText.TabIndex = 2;
            lbl_AlarmText.Text = "报警";
            lbl_AlarmText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userDeviceAlarmState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "userDeviceAlarmState";
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UISymbolLabel lbl_Alarm;
        private Sunny.UI.UILabel lbl_AlarmText;
    }
}
