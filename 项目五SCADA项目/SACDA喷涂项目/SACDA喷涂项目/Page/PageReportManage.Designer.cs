namespace SACDA喷涂项目
{
    partial class PageReportManage
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pgn_Data = new Sunny.UI.UIPagination();
            dgv_Data = new Sunny.UI.UIDataGridView();
            脱脂喷淋泵压力值 = new DataGridViewTextBoxColumn();
            脱脂PH值 = new DataGridViewTextBoxColumn();
            陶化喷淋泵压力值 = new DataGridViewTextBoxColumn();
            陶化PH值 = new DataGridViewTextBoxColumn();
            精洗喷淋泵压力值 = new DataGridViewTextBoxColumn();
            粗洗喷淋泵压力值 = new DataGridViewTextBoxColumn();
            水分炉测量温度 = new DataGridViewTextBoxColumn();
            固化炉测量温度 = new DataGridViewTextBoxColumn();
            厂内温度 = new DataGridViewTextBoxColumn();
            厂内湿度 = new DataGridViewTextBoxColumn();
            btn_ExprotData = new Sunny.UI.UISymbolButton();
            btn_QueryData = new Sunny.UI.UISymbolButton();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            dte_Start = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // pgn_Data
            // 
            pgn_Data.ButtonFillSelectedColor = Color.FromArgb(64, 128, 204);
            pgn_Data.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pgn_Data.Location = new Point(12, 500);
            pgn_Data.Margin = new Padding(4, 5, 4, 5);
            pgn_Data.MinimumSize = new Size(1, 1);
            pgn_Data.Name = "pgn_Data";
            pgn_Data.RectSides = ToolStripStatusLabelBorderSides.None;
            pgn_Data.ShowText = false;
            pgn_Data.Size = new Size(1039, 35);
            pgn_Data.TabIndex = 18;
            pgn_Data.Text = "uiPagination1";
            pgn_Data.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgv_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Data.BackgroundColor = Color.White;
            dgv_Data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Data.ColumnHeadersHeight = 45;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { 脱脂喷淋泵压力值, 脱脂PH值, 陶化喷淋泵压力值, 陶化PH值, 精洗喷淋泵压力值, 粗洗喷淋泵压力值, 水分炉测量温度, 固化炉测量温度, 厂内温度, 厂内湿度 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_Data.EnableHeadersVisualStyles = false;
            dgv_Data.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_Data.GridColor = Color.FromArgb(80, 160, 255);
            dgv_Data.Location = new Point(12, 70);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_Data.RowHeadersWidth = 38;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Data.SelectedIndex = -1;
            dgv_Data.Size = new Size(1061, 422);
            dgv_Data.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_Data.TabIndex = 17;
            // 
            // 脱脂喷淋泵压力值
            // 
            脱脂喷淋泵压力值.DataPropertyName = "脱脂喷淋泵压力值";
            脱脂喷淋泵压力值.HeaderText = "脱脂喷淋泵压力值";
            脱脂喷淋泵压力值.Name = "脱脂喷淋泵压力值";
            脱脂喷淋泵压力值.ReadOnly = true;
            脱脂喷淋泵压力值.Width = 120;
            // 
            // 脱脂PH值
            // 
            脱脂PH值.DataPropertyName = "脱脂PH值";
            脱脂PH值.HeaderText = "脱脂PH值";
            脱脂PH值.Name = "脱脂PH值";
            脱脂PH值.ReadOnly = true;
            脱脂PH值.Width = 120;
            // 
            // 陶化喷淋泵压力值
            // 
            陶化喷淋泵压力值.DataPropertyName = "陶化喷淋泵压力值";
            陶化喷淋泵压力值.HeaderText = "陶化喷淋泵压力值";
            陶化喷淋泵压力值.Name = "陶化喷淋泵压力值";
            陶化喷淋泵压力值.ReadOnly = true;
            陶化喷淋泵压力值.Width = 140;
            // 
            // 陶化PH值
            // 
            陶化PH值.DataPropertyName = "陶化PH值";
            陶化PH值.HeaderText = "陶化PH值";
            陶化PH值.Name = "陶化PH值";
            陶化PH值.ReadOnly = true;
            // 
            // 精洗喷淋泵压力值
            // 
            精洗喷淋泵压力值.DataPropertyName = "精洗喷淋泵压力值";
            精洗喷淋泵压力值.HeaderText = "精洗喷淋泵压力值";
            精洗喷淋泵压力值.Name = "精洗喷淋泵压力值";
            精洗喷淋泵压力值.ReadOnly = true;
            // 
            // 粗洗喷淋泵压力值
            // 
            粗洗喷淋泵压力值.DataPropertyName = "粗洗喷淋泵压力值";
            粗洗喷淋泵压力值.HeaderText = "粗洗喷淋泵压力值";
            粗洗喷淋泵压力值.Name = "粗洗喷淋泵压力值";
            粗洗喷淋泵压力值.ReadOnly = true;
            // 
            // 水分炉测量温度
            // 
            水分炉测量温度.DataPropertyName = "水分炉测量温度";
            水分炉测量温度.HeaderText = "水分炉测量温度";
            水分炉测量温度.Name = "水分炉测量温度";
            水分炉测量温度.ReadOnly = true;
            // 
            // 固化炉测量温度
            // 
            固化炉测量温度.DataPropertyName = "固化炉测量温度";
            固化炉测量温度.HeaderText = "固化炉测量温度";
            固化炉测量温度.Name = "固化炉测量温度";
            固化炉测量温度.ReadOnly = true;
            // 
            // 厂内温度
            // 
            厂内温度.DataPropertyName = "厂内温度";
            厂内温度.HeaderText = "厂内温度";
            厂内温度.Name = "厂内温度";
            厂内温度.ReadOnly = true;
            厂内温度.Width = 90;
            // 
            // 厂内湿度
            // 
            厂内湿度.DataPropertyName = "厂内湿度";
            厂内湿度.HeaderText = "厂内湿度";
            厂内湿度.Name = "厂内湿度";
            厂内湿度.ReadOnly = true;
            厂内湿度.Width = 90;
            // 
            // btn_ExprotData
            // 
            btn_ExprotData.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ExprotData.Location = new Point(873, 13);
            btn_ExprotData.MinimumSize = new Size(1, 1);
            btn_ExprotData.Name = "btn_ExprotData";
            btn_ExprotData.Size = new Size(132, 38);
            btn_ExprotData.Symbol = 362831;
            btn_ExprotData.TabIndex = 16;
            btn_ExprotData.Text = "导出数据";
            btn_ExprotData.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_QueryData
            // 
            btn_QueryData.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_QueryData.Location = new Point(700, 13);
            btn_QueryData.MinimumSize = new Size(1, 1);
            btn_QueryData.Name = "btn_QueryData";
            btn_QueryData.Size = new Size(132, 38);
            btn_QueryData.Symbol = 559520;
            btn_QueryData.TabIndex = 15;
            btn_QueryData.Text = "查询数据";
            btn_QueryData.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiDatetimePicker1
            // 
            uiDatetimePicker1.FillColor = Color.White;
            uiDatetimePicker1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatetimePicker1.Location = new Point(445, 22);
            uiDatetimePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker1.MaxLength = 19;
            uiDatetimePicker1.MinimumSize = new Size(63, 0);
            uiDatetimePicker1.Name = "uiDatetimePicker1";
            uiDatetimePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker1.Size = new Size(200, 29);
            uiDatetimePicker1.SymbolDropDown = 61555;
            uiDatetimePicker1.SymbolNormal = 61555;
            uiDatetimePicker1.SymbolSize = 24;
            uiDatetimePicker1.TabIndex = 14;
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2025, 10, 27, 19, 18, 18, 718);
            uiDatetimePicker1.Watermark = "";
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel2.Location = new Point(343, 22);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(95, 22);
            uiSymbolLabel2.Symbol = 62067;
            uiSymbolLabel2.TabIndex = 13;
            uiSymbolLabel2.Text = "结束时间";
            // 
            // dte_Start
            // 
            dte_Start.FillColor = Color.White;
            dte_Start.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dte_Start.Location = new Point(125, 22);
            dte_Start.Margin = new Padding(4, 5, 4, 5);
            dte_Start.MaxLength = 19;
            dte_Start.MinimumSize = new Size(63, 0);
            dte_Start.Name = "dte_Start";
            dte_Start.Padding = new Padding(0, 0, 30, 2);
            dte_Start.Size = new Size(200, 29);
            dte_Start.SymbolDropDown = 61555;
            dte_Start.SymbolNormal = 61555;
            dte_Start.SymbolSize = 24;
            dte_Start.TabIndex = 12;
            dte_Start.TextAlignment = ContentAlignment.MiddleLeft;
            dte_Start.Value = new DateTime(2025, 10, 27, 19, 18, 18, 718);
            dte_Start.Watermark = "";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new Point(23, 22);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(95, 22);
            uiSymbolLabel1.TabIndex = 11;
            uiSymbolLabel1.Text = "开始时间";
            // 
            // PageReportManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(pgn_Data);
            Controls.Add(dgv_Data);
            Controls.Add(btn_ExprotData);
            Controls.Add(btn_QueryData);
            Controls.Add(uiDatetimePicker1);
            Controls.Add(uiSymbolLabel2);
            Controls.Add(dte_Start);
            Controls.Add(uiSymbolLabel1);
            Name = "PageReportManage";
            Symbol = 57586;
            Text = "报表管理";
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPagination pgn_Data;
        private Sunny.UI.UIDataGridView dgv_Data;
        private DataGridViewTextBoxColumn 脱脂喷淋泵压力值;
        private DataGridViewTextBoxColumn 脱脂PH值;
        private DataGridViewTextBoxColumn 陶化喷淋泵压力值;
        private DataGridViewTextBoxColumn 陶化PH值;
        private DataGridViewTextBoxColumn 精洗喷淋泵压力值;
        private DataGridViewTextBoxColumn 粗洗喷淋泵压力值;
        private DataGridViewTextBoxColumn 水分炉测量温度;
        private DataGridViewTextBoxColumn 固化炉测量温度;
        private DataGridViewTextBoxColumn 厂内温度;
        private DataGridViewTextBoxColumn 厂内湿度;
        private Sunny.UI.UISymbolButton btn_ExprotData;
        private Sunny.UI.UISymbolButton btn_QueryData;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIDatetimePicker dte_Start;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}