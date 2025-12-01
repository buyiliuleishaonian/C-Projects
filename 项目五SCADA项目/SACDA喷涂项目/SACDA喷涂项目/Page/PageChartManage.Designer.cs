namespace SACDA喷涂项目
{
    partial class PageChartManage
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
            btn_QueryData = new Sunny.UI.UISymbolButton();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            dte_Start = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            lc_Chart = new Sunny.UI.UILineChart();
            SuspendLayout();
            // 
            // btn_QueryData
            // 
            btn_QueryData.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_QueryData.Location = new Point(716, 13);
            btn_QueryData.MinimumSize = new Size(1, 1);
            btn_QueryData.Name = "btn_QueryData";
            btn_QueryData.Size = new Size(132, 38);
            btn_QueryData.Symbol = 559520;
            btn_QueryData.TabIndex = 20;
            btn_QueryData.Text = "查询数据";
            btn_QueryData.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiDatetimePicker1
            // 
            uiDatetimePicker1.FillColor = Color.White;
            uiDatetimePicker1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatetimePicker1.Location = new Point(461, 22);
            uiDatetimePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker1.MaxLength = 19;
            uiDatetimePicker1.MinimumSize = new Size(63, 0);
            uiDatetimePicker1.Name = "uiDatetimePicker1";
            uiDatetimePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker1.Size = new Size(200, 29);
            uiDatetimePicker1.SymbolDropDown = 61555;
            uiDatetimePicker1.SymbolNormal = 61555;
            uiDatetimePicker1.SymbolSize = 24;
            uiDatetimePicker1.TabIndex = 19;
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2025, 10, 27, 19, 18, 18, 718);
            uiDatetimePicker1.Watermark = "";
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel2.Location = new Point(359, 22);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(95, 22);
            uiSymbolLabel2.Symbol = 62067;
            uiSymbolLabel2.TabIndex = 18;
            uiSymbolLabel2.Text = "结束时间";
            // 
            // dte_Start
            // 
            dte_Start.FillColor = Color.White;
            dte_Start.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dte_Start.Location = new Point(141, 22);
            dte_Start.Margin = new Padding(4, 5, 4, 5);
            dte_Start.MaxLength = 19;
            dte_Start.MinimumSize = new Size(63, 0);
            dte_Start.Name = "dte_Start";
            dte_Start.Padding = new Padding(0, 0, 30, 2);
            dte_Start.Size = new Size(200, 29);
            dte_Start.SymbolDropDown = 61555;
            dte_Start.SymbolNormal = 61555;
            dte_Start.SymbolSize = 24;
            dte_Start.TabIndex = 17;
            dte_Start.TextAlignment = ContentAlignment.MiddleLeft;
            dte_Start.Value = new DateTime(2025, 10, 27, 19, 18, 18, 718);
            dte_Start.Watermark = "";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new Point(39, 22);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(95, 22);
            uiSymbolLabel1.TabIndex = 16;
            uiSymbolLabel1.Text = "开始时间";
            // 
            // lc_Chart
            // 
            lc_Chart.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lc_Chart.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lc_Chart.Location = new Point(12, 62);
            lc_Chart.MinimumSize = new Size(1, 1);
            lc_Chart.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            lc_Chart.Name = "lc_Chart";
            lc_Chart.Size = new Size(975, 475);
            lc_Chart.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lc_Chart.TabIndex = 21;
            lc_Chart.Text = "uiLineChart1";
            // 
            // PageChartManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(lc_Chart);
            Controls.Add(btn_QueryData);
            Controls.Add(uiDatetimePicker1);
            Controls.Add(uiSymbolLabel2);
            Controls.Add(dte_Start);
            Controls.Add(uiSymbolLabel1);
            Name = "PageChartManage";
            Symbol = 61950;
            Text = "图表管理";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISymbolButton btn_QueryData;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIDatetimePicker dte_Start;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILineChart lc_Chart;
    }
}