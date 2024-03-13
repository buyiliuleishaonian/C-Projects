namespace Wen.ProConfigSysUI
{
    partial class FrmVariableAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVariableAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CGname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_VariableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StartAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_DataType = new System.Windows.Forms.ComboBox();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_IsMaxAlarm = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_AlarmMax = new System.Windows.Forms.TextBox();
            this.txt_AlarmMaxNode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_AlarmMinNode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AlarmMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chk_IsMinAlarm = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_Scale = new System.Windows.Forms.NumericUpDown();
            this.nud_OffsetorLength = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_IsFile = new System.Windows.Forms.CheckBox();
            this.btn_AddVariable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OffsetorLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "通信组名称：";
            // 
            // lbl_CGname
            // 
            this.lbl_CGname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_CGname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CGname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_CGname.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CGname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CGname.Location = new System.Drawing.Point(171, 31);
            this.lbl_CGname.Name = "lbl_CGname";
            this.lbl_CGname.Size = new System.Drawing.Size(287, 27);
            this.lbl_CGname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "变量名称：";
            // 
            // txt_VariableName
            // 
            this.txt_VariableName.Location = new System.Drawing.Point(171, 90);
            this.txt_VariableName.Name = "txt_VariableName";
            this.txt_VariableName.Size = new System.Drawing.Size(287, 33);
            this.txt_VariableName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "开始地址：";
            // 
            // txt_StartAddress
            // 
            this.txt_StartAddress.Location = new System.Drawing.Point(171, 155);
            this.txt_StartAddress.Name = "txt_StartAddress";
            this.txt_StartAddress.Size = new System.Drawing.Size(287, 33);
            this.txt_StartAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "数据类型:";
            // 
            // cmb_DataType
            // 
            this.cmb_DataType.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_DataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DataType.FormattingEnabled = true;
            this.cmb_DataType.Items.AddRange(new object[] {
            "Bool",
            "Byte",
            "Short",
            "UShort",
            "Int",
            "Uint",
            "Float",
            "Double",
            "Long",
            "ULong",
            "String",
            "ByteArray",
            "HexString"});
            this.cmb_DataType.Location = new System.Drawing.Point(171, 219);
            this.cmb_DataType.Name = "cmb_DataType";
            this.cmb_DataType.Size = new System.Drawing.Size(287, 34);
            this.cmb_DataType.TabIndex = 6;
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(171, 285);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(287, 33);
            this.txt_Comments.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "说明：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(503, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "报警相关配置：";
            // 
            // chk_IsMaxAlarm
            // 
            this.chk_IsMaxAlarm.AutoSize = true;
            this.chk_IsMaxAlarm.Location = new System.Drawing.Point(508, 93);
            this.chk_IsMaxAlarm.Name = "chk_IsMaxAlarm";
            this.chk_IsMaxAlarm.Size = new System.Drawing.Size(145, 30);
            this.chk_IsMaxAlarm.TabIndex = 2;
            this.chk_IsMaxAlarm.Text = "启用上限报警";
            this.chk_IsMaxAlarm.UseVisualStyleBackColor = true;
            this.chk_IsMaxAlarm.CheckedChanged += new System.EventHandler(this.chk_IsMaxAlarm_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(672, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "报警上限：";
            // 
            // txt_AlarmMax
            // 
            this.txt_AlarmMax.Location = new System.Drawing.Point(801, 90);
            this.txt_AlarmMax.Name = "txt_AlarmMax";
            this.txt_AlarmMax.Size = new System.Drawing.Size(137, 33);
            this.txt_AlarmMax.TabIndex = 3;
            // 
            // txt_AlarmMaxNode
            // 
            this.txt_AlarmMaxNode.Location = new System.Drawing.Point(651, 152);
            this.txt_AlarmMaxNode.Name = "txt_AlarmMaxNode";
            this.txt_AlarmMaxNode.Size = new System.Drawing.Size(287, 33);
            this.txt_AlarmMaxNode.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(502, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "报警上限说明：";
            // 
            // txt_AlarmMinNode
            // 
            this.txt_AlarmMinNode.Location = new System.Drawing.Point(662, 285);
            this.txt_AlarmMinNode.Name = "txt_AlarmMinNode";
            this.txt_AlarmMinNode.Size = new System.Drawing.Size(287, 33);
            this.txt_AlarmMinNode.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(513, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "报警下限说明：";
            // 
            // txt_AlarmMin
            // 
            this.txt_AlarmMin.Location = new System.Drawing.Point(801, 219);
            this.txt_AlarmMin.Name = "txt_AlarmMin";
            this.txt_AlarmMin.Size = new System.Drawing.Size(137, 33);
            this.txt_AlarmMin.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(672, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 27);
            this.label11.TabIndex = 17;
            this.label11.Text = "报警下限：";
            // 
            // chk_IsMinAlarm
            // 
            this.chk_IsMinAlarm.AutoSize = true;
            this.chk_IsMinAlarm.Location = new System.Drawing.Point(508, 222);
            this.chk_IsMinAlarm.Name = "chk_IsMinAlarm";
            this.chk_IsMinAlarm.Size = new System.Drawing.Size(145, 30);
            this.chk_IsMinAlarm.TabIndex = 7;
            this.chk_IsMinAlarm.Text = "启用下限报警";
            this.chk_IsMinAlarm.UseVisualStyleBackColor = true;
            this.chk_IsMinAlarm.CheckedChanged += new System.EventHandler(this.chk_IsMinAlarm_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(22, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 27);
            this.label12.TabIndex = 21;
            this.label12.Text = "线性系数：";
            // 
            // nud_Scale
            // 
            this.nud_Scale.DecimalPlaces = 1;
            this.nud_Scale.Location = new System.Drawing.Point(172, 350);
            this.nud_Scale.Name = "nud_Scale";
            this.nud_Scale.Size = new System.Drawing.Size(120, 33);
            this.nud_Scale.TabIndex = 10;
            this.nud_Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_OffsetorLength
            // 
            this.nud_OffsetorLength.DecimalPlaces = 1;
            this.nud_OffsetorLength.Location = new System.Drawing.Point(496, 350);
            this.nud_OffsetorLength.Name = "nud_OffsetorLength";
            this.nud_OffsetorLength.Size = new System.Drawing.Size(120, 33);
            this.nud_OffsetorLength.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(346, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 27);
            this.label13.TabIndex = 23;
            this.label13.Text = "线性偏移：";
            // 
            // chk_IsFile
            // 
            this.chk_IsFile.AutoSize = true;
            this.chk_IsFile.Location = new System.Drawing.Point(651, 351);
            this.chk_IsFile.Name = "chk_IsFile";
            this.chk_IsFile.Size = new System.Drawing.Size(107, 30);
            this.chk_IsFile.TabIndex = 25;
            this.chk_IsFile.Text = "是否归档";
            this.chk_IsFile.UseVisualStyleBackColor = true;
            // 
            // btn_AddVariable
            // 
            this.btn_AddVariable.BackColor = System.Drawing.Color.Cyan;
            this.btn_AddVariable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddVariable.Location = new System.Drawing.Point(810, 345);
            this.btn_AddVariable.Name = "btn_AddVariable";
            this.btn_AddVariable.Size = new System.Drawing.Size(119, 40);
            this.btn_AddVariable.TabIndex = 26;
            this.btn_AddVariable.Text = "增加变量";
            this.btn_AddVariable.UseVisualStyleBackColor = false;
            this.btn_AddVariable.Click += new System.EventHandler(this.btn_AddVariable_Click);
            // 
            // FrmVariableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 420);
            this.Controls.Add(this.btn_AddVariable);
            this.Controls.Add(this.chk_IsFile);
            this.Controls.Add(this.nud_OffsetorLength);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nud_Scale);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_AlarmMinNode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_AlarmMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chk_IsMinAlarm);
            this.Controls.Add(this.txt_AlarmMaxNode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_AlarmMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk_IsMaxAlarm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_DataType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_StartAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_VariableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_CGname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVariableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "变量配置";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OffsetorLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CGname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_VariableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StartAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_DataType;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_IsMaxAlarm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_AlarmMax;
        private System.Windows.Forms.TextBox txt_AlarmMaxNode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_AlarmMinNode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_AlarmMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk_IsMinAlarm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_Scale;
        private System.Windows.Forms.NumericUpDown nud_OffsetorLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chk_IsFile;
        private System.Windows.Forms.Button btn_AddVariable;
    }
}