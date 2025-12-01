namespace SACDA喷涂项目
{
    partial class PageLogManage
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
            btn_ExportToExcel = new Sunny.UI.UISymbolButton();
            btn_ShowToTxt = new Sunny.UI.UISymbolButton();
            btn_ShowToDGV = new Sunny.UI.UISymbolButton();
            btn_OpenDire = new Sunny.UI.UISymbolButton();
            lst_Files = new Sunny.UI.UIListBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            cmb_Date = new Sunny.UI.UIComboBox();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            txt_ShowLog = new Sunny.UI.UITextBox();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            txt_ShowDgv = new Sunny.UI.UITextBox();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(btn_ExportToExcel);
            uiTitlePanel1.Controls.Add(btn_ShowToTxt);
            uiTitlePanel1.Controls.Add(btn_ShowToDGV);
            uiTitlePanel1.Controls.Add(btn_OpenDire);
            uiTitlePanel1.Controls.Add(lst_Files);
            uiTitlePanel1.Controls.Add(uiComboBox1);
            uiTitlePanel1.Controls.Add(cmb_Date);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(4, 3);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(329, 542);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "日志控制台";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btn_ExportToExcel
            // 
            btn_ExportToExcel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ExportToExcel.Location = new Point(9, 470);
            btn_ExportToExcel.MinimumSize = new Size(1, 1);
            btn_ExportToExcel.Name = "btn_ExportToExcel";
            btn_ExportToExcel.Size = new Size(308, 67);
            btn_ExportToExcel.Symbol = 261564;
            btn_ExportToExcel.TabIndex = 6;
            btn_ExportToExcel.Text = "日志导出Excel";
            btn_ExportToExcel.TipsFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            // 
            // btn_ShowToTxt
            // 
            btn_ShowToTxt.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ShowToTxt.Location = new Point(9, 394);
            btn_ShowToTxt.MinimumSize = new Size(1, 1);
            btn_ShowToTxt.Name = "btn_ShowToTxt";
            btn_ShowToTxt.Size = new Size(308, 67);
            btn_ShowToTxt.Symbol = 261564;
            btn_ShowToTxt.TabIndex = 5;
            btn_ShowToTxt.Text = "日志导出TXT";
            btn_ShowToTxt.TipsFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            // 
            // btn_ShowToDGV
            // 
            btn_ShowToDGV.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ShowToDGV.Location = new Point(9, 318);
            btn_ShowToDGV.MinimumSize = new Size(1, 1);
            btn_ShowToDGV.Name = "btn_ShowToDGV";
            btn_ShowToDGV.Size = new Size(308, 67);
            btn_ShowToDGV.Symbol = 261564;
            btn_ShowToDGV.TabIndex = 4;
            btn_ShowToDGV.Text = "显示到表格";
            btn_ShowToDGV.TipsFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            // 
            // btn_OpenDire
            // 
            btn_OpenDire.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_OpenDire.Location = new Point(9, 242);
            btn_OpenDire.MinimumSize = new Size(1, 1);
            btn_OpenDire.Name = "btn_OpenDire";
            btn_OpenDire.Size = new Size(308, 67);
            btn_OpenDire.Symbol = 261564;
            btn_OpenDire.TabIndex = 3;
            btn_OpenDire.Text = "打开日志目录";
            btn_OpenDire.TipsFont = new Font("微软雅黑", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            // 
            // lst_Files
            // 
            lst_Files.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lst_Files.HoverColor = Color.FromArgb(155, 200, 255);
            lst_Files.ItemSelectForeColor = Color.White;
            lst_Files.Location = new Point(11, 82);
            lst_Files.Margin = new Padding(4, 5, 4, 5);
            lst_Files.MinimumSize = new Size(1, 1);
            lst_Files.Name = "lst_Files";
            lst_Files.Padding = new Padding(2);
            lst_Files.Radius = 1;
            lst_Files.ShowText = false;
            lst_Files.Size = new Size(308, 152);
            lst_Files.TabIndex = 2;
            lst_Files.Text = "uiListBox1";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(174, 54);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(150, 29);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 1;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "选择等级";
            // 
            // cmb_Date
            // 
            cmb_Date.DataSource = null;
            cmb_Date.FillColor = Color.White;
            cmb_Date.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cmb_Date.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmb_Date.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmb_Date.Location = new Point(9, 54);
            cmb_Date.Margin = new Padding(4, 5, 4, 5);
            cmb_Date.MinimumSize = new Size(63, 0);
            cmb_Date.Name = "cmb_Date";
            cmb_Date.Padding = new Padding(0, 0, 30, 2);
            cmb_Date.Size = new Size(150, 29);
            cmb_Date.SymbolSize = 24;
            cmb_Date.TabIndex = 0;
            cmb_Date.TextAlignment = ContentAlignment.MiddleLeft;
            cmb_Date.Watermark = "选择日期";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(txt_ShowLog);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(335, 3);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(293, 542);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "文本显示";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_ShowLog
            // 
            txt_ShowLog.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_ShowLog.Location = new Point(0, 42);
            txt_ShowLog.Margin = new Padding(4, 5, 4, 5);
            txt_ShowLog.MinimumSize = new Size(1, 16);
            txt_ShowLog.Multiline = true;
            txt_ShowLog.Name = "txt_ShowLog";
            txt_ShowLog.Padding = new Padding(5);
            txt_ShowLog.ShowText = false;
            txt_ShowLog.Size = new Size(292, 494);
            txt_ShowLog.TabIndex = 0;
            txt_ShowLog.Text = "文本显示";
            txt_ShowLog.TextAlignment = ContentAlignment.MiddleLeft;
            txt_ShowLog.Watermark = "";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(txt_ShowDgv);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel3.Location = new Point(630, 3);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(453, 542);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "表格显示";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_ShowDgv
            // 
            txt_ShowDgv.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_ShowDgv.Location = new Point(0, 42);
            txt_ShowDgv.Margin = new Padding(4, 5, 4, 5);
            txt_ShowDgv.MinimumSize = new Size(1, 16);
            txt_ShowDgv.Multiline = true;
            txt_ShowDgv.Name = "txt_ShowDgv";
            txt_ShowDgv.Padding = new Padding(5);
            txt_ShowDgv.ShowText = false;
            txt_ShowDgv.Size = new Size(451, 496);
            txt_ShowDgv.TabIndex = 0;
            txt_ShowDgv.Text = "文本显示";
            txt_ShowDgv.TextAlignment = ContentAlignment.MiddleLeft;
            txt_ShowDgv.Watermark = "";
            // 
            // PageLogManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageLogManage";
            Symbol = 162333;
            Text = "日志管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIListBox lst_Files;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox cmb_Date;
        private Sunny.UI.UISymbolButton btn_ExportToExcel;
        private Sunny.UI.UISymbolButton btn_ShowToTxt;
        private Sunny.UI.UISymbolButton btn_ShowToDGV;
        private Sunny.UI.UISymbolButton btn_OpenDire;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox txt_ShowLog;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UITextBox txt_ShowDgv;
    }
}