namespace SACDA喷涂项目
{
    partial class PageToalEquipmentControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            usbtn_EmptyRun = new UserControlButton();
            btn_AlarmReset = new Sunny.UI.UISymbolButton();
            btn_MachineReset = new Sunny.UI.UISymbolButton();
            btn_Stop = new Sunny.UI.UISymbolButton();
            btn_Start = new Sunny.UI.UISymbolButton();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            device_SSJ = new UserDeviceUnitControl();
            device_GHL = new UserDeviceUnitControl();
            device_LQS = new UserDeviceUnitControl();
            device_SFL = new UserDeviceUnitControl();
            device_JX = new UserDeviceUnitControl();
            device_TH = new UserDeviceUnitControl();
            device_CX = new UserDeviceUnitControl();
            dervice_TZ = new UserDeviceUnitControl();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            txt_Log = new Sunny.UI.UITextBox();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(usbtn_EmptyRun);
            uiTitlePanel1.Controls.Add(btn_AlarmReset);
            uiTitlePanel1.Controls.Add(btn_MachineReset);
            uiTitlePanel1.Controls.Add(btn_Stop);
            uiTitlePanel1.Controls.Add(btn_Start);
            uiTitlePanel1.Dock = DockStyle.Top;
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(0, 0);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1085, 157);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "产线总控制";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // usbtn_EmptyRun
            // 
            usbtn_EmptyRun.BackColor = Color.Transparent;
            usbtn_EmptyRun.CountButtonStyle = false;
            usbtn_EmptyRun.CountButtonSymbol = 558653;
            usbtn_EmptyRun.CountButtonText = "空运行";
            usbtn_EmptyRun.FillColor = Color.Transparent;
            usbtn_EmptyRun.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            usbtn_EmptyRun.Location = new Point(874, 60);
            usbtn_EmptyRun.MinimumSize = new Size(1, 1);
            usbtn_EmptyRun.Name = "usbtn_EmptyRun";
            usbtn_EmptyRun.Radius = 10;
            usbtn_EmptyRun.RectColor = Color.Transparent;
            usbtn_EmptyRun.Size = new Size(181, 84);
            usbtn_EmptyRun.TabIndex = 4;
            usbtn_EmptyRun.Text = "userControlButton1";
            usbtn_EmptyRun.TextAlignment = ContentAlignment.MiddleCenter;
            usbtn_EmptyRun.VariableName = null;
            // 
            // btn_AlarmReset
            // 
            btn_AlarmReset.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_AlarmReset.Location = new Point(653, 60);
            btn_AlarmReset.MinimumSize = new Size(1, 1);
            btn_AlarmReset.Name = "btn_AlarmReset";
            btn_AlarmReset.Radius = 10;
            btn_AlarmReset.Size = new Size(181, 84);
            btn_AlarmReset.Symbol = 61473;
            btn_AlarmReset.SymbolSize = 55;
            btn_AlarmReset.TabIndex = 3;
            btn_AlarmReset.TagString = "报警复位";
            btn_AlarmReset.Text = "报警复位";
            btn_AlarmReset.TipsFont = new Font("微软雅黑", 21.25F);
            // 
            // btn_MachineReset
            // 
            btn_MachineReset.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_MachineReset.Location = new Point(446, 60);
            btn_MachineReset.MinimumSize = new Size(1, 1);
            btn_MachineReset.Name = "btn_MachineReset";
            btn_MachineReset.Radius = 10;
            btn_MachineReset.Size = new Size(181, 84);
            btn_MachineReset.Symbol = 61473;
            btn_MachineReset.SymbolSize = 55;
            btn_MachineReset.TabIndex = 2;
            btn_MachineReset.TagString = "机械复位";
            btn_MachineReset.Text = "机械复位";
            btn_MachineReset.TipsFont = new Font("微软雅黑", 21.25F);
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Stop.Location = new Point(239, 60);
            btn_Stop.MinimumSize = new Size(1, 1);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Radius = 10;
            btn_Stop.Size = new Size(181, 84);
            btn_Stop.Symbol = 62093;
            btn_Stop.SymbolSize = 55;
            btn_Stop.TabIndex = 1;
            btn_Stop.TagString = "总停止";
            btn_Stop.Text = "总停止";
            btn_Stop.TipsFont = new Font("微软雅黑", 21.25F);
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Start.Location = new Point(32, 60);
            btn_Start.MinimumSize = new Size(1, 1);
            btn_Start.Name = "btn_Start";
            btn_Start.Radius = 10;
            btn_Start.Size = new Size(181, 84);
            btn_Start.Symbol = 561649;
            btn_Start.SymbolSize = 55;
            btn_Start.TabIndex = 0;
            btn_Start.TagString = "总启动";
            btn_Start.Text = "总启动";
            btn_Start.TipsFont = new Font("微软雅黑", 21.25F);
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(device_SSJ);
            uiTitlePanel2.Controls.Add(device_GHL);
            uiTitlePanel2.Controls.Add(device_LQS);
            uiTitlePanel2.Controls.Add(device_SFL);
            uiTitlePanel2.Controls.Add(device_JX);
            uiTitlePanel2.Controls.Add(device_TH);
            uiTitlePanel2.Controls.Add(device_CX);
            uiTitlePanel2.Controls.Add(dervice_TZ);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(8, 167);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(602, 374);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "产线总控制";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_SSJ
            // 
            device_SSJ.BackColor = Color.FromArgb(243, 249, 255);
            device_SSJ.CloseVariableName = "输送机工位关";
            device_SSJ.EquipmentUnitName = "输送机工位";
            device_SSJ.FillColor = Color.Transparent;
            device_SSJ.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_SSJ.Location = new Point(297, 286);
            device_SSJ.MinimumSize = new Size(1, 1);
            device_SSJ.Name = "device_SSJ";
            device_SSJ.OpenVariableName = "输送机工位开";
            device_SSJ.RectColor = Color.Transparent;
            device_SSJ.Size = new Size(250, 60);
            device_SSJ.State = false;
            device_SSJ.TabIndex = 7;
            device_SSJ.Text = null;
            device_SSJ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_GHL
            // 
            device_GHL.BackColor = Color.FromArgb(243, 249, 255);
            device_GHL.CloseVariableName = "固化炉工位关";
            device_GHL.EquipmentUnitName = "固化炉工位";
            device_GHL.FillColor = Color.Transparent;
            device_GHL.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_GHL.Location = new Point(297, 209);
            device_GHL.MinimumSize = new Size(1, 1);
            device_GHL.Name = "device_GHL";
            device_GHL.OpenVariableName = "固化炉工位开";
            device_GHL.RectColor = Color.Transparent;
            device_GHL.Size = new Size(250, 60);
            device_GHL.State = false;
            device_GHL.TabIndex = 6;
            device_GHL.Text = null;
            device_GHL.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_LQS
            // 
            device_LQS.BackColor = Color.FromArgb(243, 249, 255);
            device_LQS.CloseVariableName = "冷却室工位关";
            device_LQS.EquipmentUnitName = "冷却室工位";
            device_LQS.FillColor = Color.Transparent;
            device_LQS.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_LQS.Location = new Point(297, 132);
            device_LQS.MinimumSize = new Size(1, 1);
            device_LQS.Name = "device_LQS";
            device_LQS.OpenVariableName = "冷却室工位开";
            device_LQS.RectColor = Color.Transparent;
            device_LQS.Size = new Size(250, 60);
            device_LQS.State = false;
            device_LQS.TabIndex = 5;
            device_LQS.Text = null;
            device_LQS.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_SFL
            // 
            device_SFL.BackColor = Color.FromArgb(243, 249, 255);
            device_SFL.CloseVariableName = "水分炉工位关";
            device_SFL.EquipmentUnitName = "水分炉工位";
            device_SFL.FillColor = Color.Transparent;
            device_SFL.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_SFL.Location = new Point(297, 55);
            device_SFL.MinimumSize = new Size(1, 1);
            device_SFL.Name = "device_SFL";
            device_SFL.OpenVariableName = "水分炉工位开";
            device_SFL.RectColor = Color.Transparent;
            device_SFL.Size = new Size(250, 60);
            device_SFL.State = false;
            device_SFL.TabIndex = 4;
            device_SFL.Text = null;
            device_SFL.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_JX
            // 
            device_JX.BackColor = Color.FromArgb(243, 249, 255);
            device_JX.CloseVariableName = "精洗工位关";
            device_JX.EquipmentUnitName = "精洗工位";
            device_JX.FillColor = Color.Transparent;
            device_JX.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_JX.Location = new Point(19, 286);
            device_JX.MinimumSize = new Size(1, 1);
            device_JX.Name = "device_JX";
            device_JX.OpenVariableName = "精洗工位开";
            device_JX.RectColor = Color.Transparent;
            device_JX.Size = new Size(250, 60);
            device_JX.State = false;
            device_JX.TabIndex = 3;
            device_JX.Text = null;
            device_JX.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_TH
            // 
            device_TH.BackColor = Color.FromArgb(243, 249, 255);
            device_TH.CloseVariableName = "陶化工位关";
            device_TH.EquipmentUnitName = "陶化工位";
            device_TH.FillColor = Color.Transparent;
            device_TH.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_TH.Location = new Point(19, 209);
            device_TH.MinimumSize = new Size(1, 1);
            device_TH.Name = "device_TH";
            device_TH.OpenVariableName = "陶化工位开";
            device_TH.RectColor = Color.Transparent;
            device_TH.Size = new Size(250, 60);
            device_TH.State = false;
            device_TH.TabIndex = 2;
            device_TH.Text = null;
            device_TH.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_CX
            // 
            device_CX.BackColor = Color.FromArgb(243, 249, 255);
            device_CX.CloseVariableName = "粗洗工位关";
            device_CX.EquipmentUnitName = "粗洗工位";
            device_CX.FillColor = Color.Transparent;
            device_CX.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            device_CX.Location = new Point(19, 132);
            device_CX.MinimumSize = new Size(1, 1);
            device_CX.Name = "device_CX";
            device_CX.OpenVariableName = "粗洗工位开";
            device_CX.RectColor = Color.Transparent;
            device_CX.Size = new Size(250, 60);
            device_CX.State = false;
            device_CX.TabIndex = 1;
            device_CX.Text = null;
            device_CX.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dervice_TZ
            // 
            dervice_TZ.BackColor = Color.FromArgb(243, 249, 255);
            dervice_TZ.CloseVariableName = "脱脂工位关";
            dervice_TZ.EquipmentUnitName = "脱脂工位";
            dervice_TZ.FillColor = Color.Transparent;
            dervice_TZ.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dervice_TZ.Location = new Point(19, 55);
            dervice_TZ.MinimumSize = new Size(1, 1);
            dervice_TZ.Name = "dervice_TZ";
            dervice_TZ.OpenVariableName = "脱脂工位开";
            dervice_TZ.RectColor = Color.Transparent;
            dervice_TZ.Size = new Size(250, 60);
            dervice_TZ.State = false;
            dervice_TZ.TabIndex = 0;
            dervice_TZ.Text = null;
            dervice_TZ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(txt_Log);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel3.Location = new Point(619, 167);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(455, 374);
            uiTitlePanel3.TabIndex = 8;
            uiTitlePanel3.Text = "产线总控制";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_Log
            // 
            txt_Log.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Log.Location = new Point(4, 47);
            txt_Log.Margin = new Padding(4, 5, 4, 5);
            txt_Log.MinimumSize = new Size(1, 16);
            txt_Log.Name = "txt_Log";
            txt_Log.Padding = new Padding(5);
            txt_Log.ShowText = false;
            txt_Log.Size = new Size(447, 321);
            txt_Log.TabIndex = 0;
            txt_Log.TextAlignment = ContentAlignment.MiddleLeft;
            txt_Log.Watermark = "";
            // 
            // PageEquipmentMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor";
            Symbol = 57397;
            Text = "设备监控";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_Start;
        private Sunny.UI.UISymbolButton btn_AlarmReset;
        private Sunny.UI.UISymbolButton btn_MachineReset;
        private Sunny.UI.UISymbolButton btn_Stop;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserDeviceUnitControl dervice_TZ;
        private UserDeviceUnitControl device_CX;
        private UserDeviceUnitControl device_TH;
        private UserDeviceUnitControl device_JX;
        private UserDeviceUnitControl device_SSJ;
        private UserDeviceUnitControl device_GHL;
        private UserDeviceUnitControl device_LQS;
        private UserDeviceUnitControl device_SFL;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UITextBox txt_Log;
        private UserControlButton usbtn_EmptyRun;
    }
}