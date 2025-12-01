using static Sunny.UI.UITextBox;

namespace SACDA喷涂项目
{
    partial class PageRecipeManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userSetValue8 = new UserSetValue();
            userSetValue9 = new UserSetValue();
            userSetValue10 = new UserSetValue();
            userSetValue11 = new UserSetValue();
            userSetValue12 = new UserSetValue();
            userSetValue13 = new UserSetValue();
            userSetValue14 = new UserSetValue();
            userSetValue7 = new UserSetValue();
            userSetValue6 = new UserSetValue();
            userSetValue3 = new UserSetValue();
            userSetValue5 = new UserSetValue();
            userSetValue4 = new UserSetValue();
            userSetValue2 = new UserSetValue();
            userSetValue1 = new UserSetValue();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            dgv_Recipe = new Sunny.UI.UIDataGridView();
            btn_DownloadRecipe = new Sunny.UI.UISymbolButton();
            btn_ExportRecipe = new Sunny.UI.UISymbolButton();
            btn_ImportRecipe = new Sunny.UI.UISymbolButton();
            btn_QueryRecipe = new Sunny.UI.UISymbolButton();
            btn_UpdateRecipe = new Sunny.UI.UISymbolButton();
            btn_DelRecipe = new Sunny.UI.UISymbolButton();
            btn_AddRecipe = new Sunny.UI.UISymbolButton();
            txt_ProductType = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).BeginInit();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userSetValue8);
            uiTitlePanel1.Controls.Add(userSetValue9);
            uiTitlePanel1.Controls.Add(userSetValue10);
            uiTitlePanel1.Controls.Add(userSetValue11);
            uiTitlePanel1.Controls.Add(userSetValue12);
            uiTitlePanel1.Controls.Add(userSetValue13);
            uiTitlePanel1.Controls.Add(userSetValue14);
            uiTitlePanel1.Controls.Add(userSetValue7);
            uiTitlePanel1.Controls.Add(userSetValue6);
            uiTitlePanel1.Controls.Add(userSetValue3);
            uiTitlePanel1.Controls.Add(userSetValue5);
            uiTitlePanel1.Controls.Add(userSetValue4);
            uiTitlePanel1.Controls.Add(userSetValue2);
            uiTitlePanel1.Controls.Add(userSetValue1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(4, 2);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(810, 541);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "配方参数";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userSetValue8
            // 
            userSetValue8.AutoSize = true;
            userSetValue8.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue8.DataType = UIEditType.Double;
            userSetValue8.DeviceName = "输送机频率";
            userSetValue8.FillColor = Color.Transparent;
            userSetValue8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue8.Location = new Point(433, 481);
            userSetValue8.MinimumSize = new Size(1, 1);
            userSetValue8.Name = "userSetValue8";
            userSetValue8.RectColor = Color.Transparent;
            userSetValue8.Size = new Size(315, 55);
            userSetValue8.TabIndex = 14;
            userSetValue8.Text = null;
            userSetValue8.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue8.Unit = "HZ";
            userSetValue8.VariableName = "输送机频率";
            userSetValue8.VarValue = null;
            // 
            // userSetValue9
            // 
            userSetValue9.AutoSize = true;
            userSetValue9.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue9.DataType = UIEditType.Double;
            userSetValue9.DeviceName = "输送机设定速度";
            userSetValue9.FillColor = Color.Transparent;
            userSetValue9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue9.Location = new Point(433, 410);
            userSetValue9.MinimumSize = new Size(1, 1);
            userSetValue9.Name = "userSetValue9";
            userSetValue9.RectColor = Color.Transparent;
            userSetValue9.Size = new Size(315, 55);
            userSetValue9.TabIndex = 13;
            userSetValue9.Text = null;
            userSetValue9.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue9.Unit = "m/s";
            userSetValue9.VariableName = "输送机设定速度";
            userSetValue9.VarValue = null;
            // 
            // userSetValue10
            // 
            userSetValue10.AutoSize = true;
            userSetValue10.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue10.DataType = UIEditType.Double;
            userSetValue10.DeviceName = "离心机过载上限值";
            userSetValue10.FillColor = Color.Transparent;
            userSetValue10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue10.Location = new Point(433, 193);
            userSetValue10.MinimumSize = new Size(1, 1);
            userSetValue10.Name = "userSetValue10";
            userSetValue10.RectColor = Color.Transparent;
            userSetValue10.Size = new Size(315, 55);
            userSetValue10.TabIndex = 12;
            userSetValue10.Text = null;
            userSetValue10.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue10.Unit = "KW";
            userSetValue10.VariableName = "离心机过载上限值";
            userSetValue10.VarValue = null;
            // 
            // userSetValue11
            // 
            userSetValue11.AutoSize = true;
            userSetValue11.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue11.DataType = UIEditType.Double;
            userSetValue11.DeviceName = "固化炉温度下限值";
            userSetValue11.FillColor = Color.Transparent;
            userSetValue11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue11.Location = new Point(433, 339);
            userSetValue11.MinimumSize = new Size(1, 1);
            userSetValue11.Name = "userSetValue11";
            userSetValue11.RectColor = Color.Transparent;
            userSetValue11.Size = new Size(315, 55);
            userSetValue11.TabIndex = 11;
            userSetValue11.Text = null;
            userSetValue11.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue11.Unit = "Mpa";
            userSetValue11.VariableName = "固化炉温度下限值";
            userSetValue11.VarValue = null;
            // 
            // userSetValue12
            // 
            userSetValue12.AutoSize = true;
            userSetValue12.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue12.DataType = UIEditType.Double;
            userSetValue12.DeviceName = "固化炉温度上限值";
            userSetValue12.FillColor = Color.Transparent;
            userSetValue12.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue12.Location = new Point(433, 264);
            userSetValue12.MinimumSize = new Size(1, 1);
            userSetValue12.Name = "userSetValue12";
            userSetValue12.RectColor = Color.Transparent;
            userSetValue12.Size = new Size(315, 55);
            userSetValue12.TabIndex = 10;
            userSetValue12.Text = null;
            userSetValue12.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue12.Unit = "℃";
            userSetValue12.VariableName = "固化炉温度上限值";
            userSetValue12.VarValue = null;
            // 
            // userSetValue13
            // 
            userSetValue13.AutoSize = true;
            userSetValue13.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue13.DataType = UIEditType.Double;
            userSetValue13.DeviceName = "水分炉温度下限值";
            userSetValue13.FillColor = Color.Transparent;
            userSetValue13.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue13.Location = new Point(433, 122);
            userSetValue13.MinimumSize = new Size(1, 1);
            userSetValue13.Name = "userSetValue13";
            userSetValue13.RectColor = Color.Transparent;
            userSetValue13.Size = new Size(315, 55);
            userSetValue13.TabIndex = 9;
            userSetValue13.Text = null;
            userSetValue13.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue13.Unit = "℃";
            userSetValue13.VariableName = "水分炉温度下限值";
            userSetValue13.VarValue = null;
            // 
            // userSetValue14
            // 
            userSetValue14.AutoSize = true;
            userSetValue14.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue14.DataType = UIEditType.Double;
            userSetValue14.DeviceName = "水分炉温度上限值";
            userSetValue14.FillColor = Color.Transparent;
            userSetValue14.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue14.Location = new Point(433, 51);
            userSetValue14.MinimumSize = new Size(1, 1);
            userSetValue14.Name = "userSetValue14";
            userSetValue14.RectColor = Color.Transparent;
            userSetValue14.Size = new Size(315, 55);
            userSetValue14.TabIndex = 8;
            userSetValue14.Text = null;
            userSetValue14.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue14.Unit = "℃";
            userSetValue14.VariableName = "水分炉温度上限值";
            userSetValue14.VarValue = null;
            // 
            // userSetValue7
            // 
            userSetValue7.AutoSize = true;
            userSetValue7.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue7.DataType = UIEditType.Double;
            userSetValue7.DeviceName = "精洗液位下限值";
            userSetValue7.FillColor = Color.Transparent;
            userSetValue7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue7.Location = new Point(43, 481);
            userSetValue7.MinimumSize = new Size(1, 1);
            userSetValue7.Name = "userSetValue7";
            userSetValue7.RectColor = Color.Transparent;
            userSetValue7.Size = new Size(352, 55);
            userSetValue7.TabIndex = 7;
            userSetValue7.Text = null;
            userSetValue7.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue7.Unit = "m³";
            userSetValue7.VariableName = "精洗液位下限值";
            userSetValue7.VarValue = null;
            // 
            // userSetValue6
            // 
            userSetValue6.AutoSize = true;
            userSetValue6.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue6.DataType = UIEditType.Double;
            userSetValue6.DeviceName = "精洗喷淋泵过载上限值";
            userSetValue6.FillColor = Color.Transparent;
            userSetValue6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue6.Location = new Point(43, 410);
            userSetValue6.MinimumSize = new Size(1, 1);
            userSetValue6.Name = "userSetValue6";
            userSetValue6.RectColor = Color.Transparent;
            userSetValue6.Size = new Size(352, 55);
            userSetValue6.TabIndex = 6;
            userSetValue6.Text = null;
            userSetValue6.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue6.Unit = "KW";
            userSetValue6.VariableName = "精洗喷淋泵过载上限值";
            userSetValue6.VarValue = null;
            // 
            // userSetValue3
            // 
            userSetValue3.AutoSize = true;
            userSetValue3.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue3.DataType = UIEditType.Double;
            userSetValue3.DeviceName = "粗洗喷淋泵过载上限值";
            userSetValue3.FillColor = Color.Transparent;
            userSetValue3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue3.Location = new Point(43, 193);
            userSetValue3.MinimumSize = new Size(1, 1);
            userSetValue3.Name = "userSetValue3";
            userSetValue3.RectColor = Color.Transparent;
            userSetValue3.Size = new Size(352, 55);
            userSetValue3.TabIndex = 5;
            userSetValue3.Text = null;
            userSetValue3.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue3.Unit = "KW";
            userSetValue3.VariableName = "脱脂设定压力下限值";
            userSetValue3.VarValue = null;
            // 
            // userSetValue5
            // 
            userSetValue5.AutoSize = true;
            userSetValue5.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue5.DataType = UIEditType.Double;
            userSetValue5.DeviceName = "陶化喷淋泵过载上限值";
            userSetValue5.FillColor = Color.Transparent;
            userSetValue5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue5.Location = new Point(43, 339);
            userSetValue5.MinimumSize = new Size(1, 1);
            userSetValue5.Name = "userSetValue5";
            userSetValue5.RectColor = Color.Transparent;
            userSetValue5.Size = new Size(352, 55);
            userSetValue5.TabIndex = 4;
            userSetValue5.Text = null;
            userSetValue5.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue5.Unit = "Mpa";
            userSetValue5.VariableName = "陶化喷淋泵过载上限值";
            userSetValue5.VarValue = null;
            // 
            // userSetValue4
            // 
            userSetValue4.AutoSize = true;
            userSetValue4.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue4.DataType = UIEditType.Double;
            userSetValue4.DeviceName = "粗洗液位下限值";
            userSetValue4.FillColor = Color.Transparent;
            userSetValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue4.Location = new Point(43, 264);
            userSetValue4.MinimumSize = new Size(1, 1);
            userSetValue4.Name = "userSetValue4";
            userSetValue4.RectColor = Color.Transparent;
            userSetValue4.Size = new Size(352, 55);
            userSetValue4.TabIndex = 3;
            userSetValue4.Text = null;
            userSetValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue4.Unit = "m³";
            userSetValue4.VariableName = "粗洗液位下限值";
            userSetValue4.VarValue = null;
            // 
            // userSetValue2
            // 
            userSetValue2.AutoSize = true;
            userSetValue2.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue2.DataType = UIEditType.Double;
            userSetValue2.DeviceName = "脱脂设定压力下限值";
            userSetValue2.FillColor = Color.Transparent;
            userSetValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue2.Location = new Point(43, 122);
            userSetValue2.MinimumSize = new Size(1, 1);
            userSetValue2.Name = "userSetValue2";
            userSetValue2.RectColor = Color.Transparent;
            userSetValue2.Size = new Size(352, 55);
            userSetValue2.TabIndex = 1;
            userSetValue2.Text = null;
            userSetValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue2.Unit = "Mpa";
            userSetValue2.VariableName = "脱脂设定压力下限值";
            userSetValue2.VarValue = null;
            // 
            // userSetValue1
            // 
            userSetValue1.AutoSize = true;
            userSetValue1.BackColor = Color.FromArgb(243, 249, 255);
            userSetValue1.DataType = UIEditType.Double;
            userSetValue1.DeviceName = "脱脂设定压力上限值";
            userSetValue1.FillColor = Color.Transparent;
            userSetValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userSetValue1.Location = new Point(43, 51);
            userSetValue1.MinimumSize = new Size(1, 1);
            userSetValue1.Name = "userSetValue1";
            userSetValue1.RectColor = Color.Transparent;
            userSetValue1.Size = new Size(352, 55);
            userSetValue1.TabIndex = 0;
            userSetValue1.Text = null;
            userSetValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue1.Unit = "Mpa";
            userSetValue1.VariableName = "脱脂设定压力上限值";
            userSetValue1.VarValue = null;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(dgv_Recipe);
            uiTitlePanel2.Controls.Add(btn_DownloadRecipe);
            uiTitlePanel2.Controls.Add(btn_ExportRecipe);
            uiTitlePanel2.Controls.Add(btn_ImportRecipe);
            uiTitlePanel2.Controls.Add(btn_QueryRecipe);
            uiTitlePanel2.Controls.Add(btn_UpdateRecipe);
            uiTitlePanel2.Controls.Add(btn_DelRecipe);
            uiTitlePanel2.Controls.Add(btn_AddRecipe);
            uiTitlePanel2.Controls.Add(txt_ProductType);
            uiTitlePanel2.Controls.Add(uiLabel1);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(812, 2);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.Padding = new Padding(1, 35, 1, 1);
            uiTitlePanel2.Radius = 2;
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(271, 541);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "配方控制平台";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgv_Recipe
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Recipe.BackgroundColor = Color.White;
            dgv_Recipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Recipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Recipe.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Recipe.EnableHeadersVisualStyles = false;
            dgv_Recipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_Recipe.GridColor = Color.FromArgb(80, 160, 255);
            dgv_Recipe.Location = new Point(9, 316);
            dgv_Recipe.Name = "dgv_Recipe";
            dgv_Recipe.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_Recipe.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Recipe.SelectedIndex = -1;
            dgv_Recipe.Size = new Size(249, 219);
            dgv_Recipe.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.TabIndex = 9;
            // 
            // btn_DownloadRecipe
            // 
            btn_DownloadRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_DownloadRecipe.Location = new Point(9, 266);
            btn_DownloadRecipe.MinimumSize = new Size(1, 1);
            btn_DownloadRecipe.Name = "btn_DownloadRecipe";
            btn_DownloadRecipe.Size = new Size(249, 50);
            btn_DownloadRecipe.Symbol = 61465;
            btn_DownloadRecipe.TabIndex = 8;
            btn_DownloadRecipe.Text = "下载配方";
            btn_DownloadRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_ExportRecipe
            // 
            btn_ExportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ExportRecipe.Location = new Point(146, 209);
            btn_ExportRecipe.MinimumSize = new Size(1, 1);
            btn_ExportRecipe.Name = "btn_ExportRecipe";
            btn_ExportRecipe.Size = new Size(121, 50);
            btn_ExportRecipe.Symbol = 362831;
            btn_ExportRecipe.TabIndex = 7;
            btn_ExportRecipe.Text = "导出配方";
            btn_ExportRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_ImportRecipe
            // 
            btn_ImportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_ImportRecipe.Location = new Point(9, 210);
            btn_ImportRecipe.MinimumSize = new Size(1, 1);
            btn_ImportRecipe.Name = "btn_ImportRecipe";
            btn_ImportRecipe.Size = new Size(121, 50);
            btn_ImportRecipe.Symbol = 362831;
            btn_ImportRecipe.TabIndex = 6;
            btn_ImportRecipe.Text = "导入配方";
            btn_ImportRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_QueryRecipe
            // 
            btn_QueryRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_QueryRecipe.Location = new Point(146, 153);
            btn_QueryRecipe.MinimumSize = new Size(1, 1);
            btn_QueryRecipe.Name = "btn_QueryRecipe";
            btn_QueryRecipe.Size = new Size(121, 50);
            btn_QueryRecipe.Symbol = 559520;
            btn_QueryRecipe.TabIndex = 5;
            btn_QueryRecipe.Text = "查询配方";
            btn_QueryRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_UpdateRecipe
            // 
            btn_UpdateRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_UpdateRecipe.Location = new Point(9, 152);
            btn_UpdateRecipe.MinimumSize = new Size(1, 1);
            btn_UpdateRecipe.Name = "btn_UpdateRecipe";
            btn_UpdateRecipe.Size = new Size(121, 50);
            btn_UpdateRecipe.Symbol = 558087;
            btn_UpdateRecipe.TabIndex = 4;
            btn_UpdateRecipe.Text = "修改配方";
            btn_UpdateRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_DelRecipe
            // 
            btn_DelRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_DelRecipe.Location = new Point(146, 92);
            btn_DelRecipe.MinimumSize = new Size(1, 1);
            btn_DelRecipe.Name = "btn_DelRecipe";
            btn_DelRecipe.Size = new Size(121, 50);
            btn_DelRecipe.Symbol = 362810;
            btn_DelRecipe.TabIndex = 3;
            btn_DelRecipe.Text = "删除配方";
            btn_DelRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_AddRecipe
            // 
            btn_AddRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_AddRecipe.Location = new Point(9, 92);
            btn_AddRecipe.MinimumSize = new Size(1, 1);
            btn_AddRecipe.Name = "btn_AddRecipe";
            btn_AddRecipe.Size = new Size(121, 50);
            btn_AddRecipe.Symbol = 557670;
            btn_AddRecipe.TabIndex = 2;
            btn_AddRecipe.Text = "添加配方";
            btn_AddRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // txt_ProductType
            // 
            txt_ProductType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_ProductType.Location = new Point(110, 52);
            txt_ProductType.Margin = new Padding(4, 5, 4, 5);
            txt_ProductType.MinimumSize = new Size(1, 16);
            txt_ProductType.Name = "txt_ProductType";
            txt_ProductType.Padding = new Padding(5);
            txt_ProductType.ShowText = false;
            txt_ProductType.Size = new Size(150, 32);
            txt_ProductType.TabIndex = 1;
            txt_ProductType.TextAlignment = ContentAlignment.MiddleCenter;
            txt_ProductType.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(9, 55);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "产品型号";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageRecipeManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageRecipeManage";
            Symbol = 162333;
            Text = "配方管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel1.PerformLayout();
            uiTitlePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserSetValue userSetValue1;
        private UserSetValue userSetValue2;
        private UserSetValue userSetValue4;
        private UserSetValue userSetValue5;
        private UserSetValue userSetValue3;
        private UserSetValue userSetValue6;
        private UserSetValue userSetValue8;
        private UserSetValue userSetValue9;
        private UserSetValue userSetValue10;
        private UserSetValue userSetValue11;
        private UserSetValue userSetValue12;
        private UserSetValue userSetValue13;
        private UserSetValue userSetValue14;
        private UserSetValue userSetValue7;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox txt_ProductType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btn_AddRecipe;
        private Sunny.UI.UISymbolButton btn_DelRecipe;
        private Sunny.UI.UISymbolButton btn_ExportRecipe;
        private Sunny.UI.UISymbolButton btn_ImportRecipe;
        private Sunny.UI.UISymbolButton btn_QueryRecipe;
        private Sunny.UI.UISymbolButton btn_UpdateRecipe;
        private Sunny.UI.UIDataGridView dgv_Recipe;
        private Sunny.UI.UISymbolButton btn_DownloadRecipe;
    }
}