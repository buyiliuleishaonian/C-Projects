namespace Wen.ProConfigSysUI
{
    partial class FrmGroupAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EquipmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GroupName = new System.Windows.Forms.TextBox();
            this.txt_StartAddRess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CGlength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_IsEnable = new System.Windows.Forms.CheckBox();
            this.btn_Add_CGroup = new System.Windows.Forms.Button();
            this.dgv_CGroup = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddRess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cglength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISenable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称：";
            // 
            // lbl_EquipmentName
            // 
            this.lbl_EquipmentName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_EquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_EquipmentName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_EquipmentName.Location = new System.Drawing.Point(146, 44);
            this.lbl_EquipmentName.Name = "lbl_EquipmentName";
            this.lbl_EquipmentName.Size = new System.Drawing.Size(285, 32);
            this.lbl_EquipmentName.TabIndex = 1;
            this.lbl_EquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "通信组名称：";
            // 
            // txt_GroupName
            // 
            this.txt_GroupName.Location = new System.Drawing.Point(583, 44);
            this.txt_GroupName.Multiline = true;
            this.txt_GroupName.Name = "txt_GroupName";
            this.txt_GroupName.Size = new System.Drawing.Size(285, 32);
            this.txt_GroupName.TabIndex = 3;
            // 
            // txt_StartAddRess
            // 
            this.txt_StartAddRess.Location = new System.Drawing.Point(1031, 44);
            this.txt_StartAddRess.Multiline = true;
            this.txt_StartAddRess.Name = "txt_StartAddRess";
            this.txt_StartAddRess.Size = new System.Drawing.Size(285, 32);
            this.txt_StartAddRess.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "起始地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "备注：";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(108, 109);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(760, 136);
            this.txt_Comments.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(914, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "通信组长度：";
            // 
            // txt_CGlength
            // 
            this.txt_CGlength.Location = new System.Drawing.Point(1031, 106);
            this.txt_CGlength.Multiline = true;
            this.txt_CGlength.Name = "txt_CGlength";
            this.txt_CGlength.Size = new System.Drawing.Size(146, 32);
            this.txt_CGlength.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1183, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "(请输录整数）";
            // 
            // chk_IsEnable
            // 
            this.chk_IsEnable.AutoSize = true;
            this.chk_IsEnable.Location = new System.Drawing.Point(919, 164);
            this.chk_IsEnable.Name = "chk_IsEnable";
            this.chk_IsEnable.Size = new System.Drawing.Size(107, 30);
            this.chk_IsEnable.TabIndex = 11;
            this.chk_IsEnable.Text = "是否启用";
            this.chk_IsEnable.UseVisualStyleBackColor = true;
            // 
            // btn_Add_CGroup
            // 
            this.btn_Add_CGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Add_CGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_CGroup.Location = new System.Drawing.Point(1089, 163);
            this.btn_Add_CGroup.Name = "btn_Add_CGroup";
            this.btn_Add_CGroup.Size = new System.Drawing.Size(161, 42);
            this.btn_Add_CGroup.TabIndex = 12;
            this.btn_Add_CGroup.Text = "增加通信组";
            this.btn_Add_CGroup.UseVisualStyleBackColor = false;
            this.btn_Add_CGroup.Click += new System.EventHandler(this.btn_Add_CGroup_Click);
            // 
            // dgv_CGroup
            // 
            this.dgv_CGroup.AllowUserToAddRows = false;
            this.dgv_CGroup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.equipmentname,
            this.CgName,
            this.StartAddRess,
            this.cglength,
            this.ISenable,
            this.comments});
            this.dgv_CGroup.Location = new System.Drawing.Point(38, 269);
            this.dgv_CGroup.Name = "dgv_CGroup";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CGroup.RowHeadersVisible = false;
            this.dgv_CGroup.RowTemplate.Height = 23;
            this.dgv_CGroup.Size = new System.Drawing.Size(1278, 357);
            this.dgv_CGroup.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "起始地址填写格式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 706);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "西门子PLC：M0,I0,Q0,DB1.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 706);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "三菱PLC：M0,X0,Y0,D0,W0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 706);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "欧姆龙PLC：M0,D0,H0,CIO0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 737);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(433, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "Modbus：1.00001,2.00001,3.40001,4.30001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(502, 737);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(394, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = ". 前面表示站号，后面表示绝对的Mdbus地址";
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "序号";
            this.SN.Name = "SN";
            this.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // equipmentname
            // 
            this.equipmentname.DataPropertyName = "equipmentname";
            this.equipmentname.HeaderText = "设备名称";
            this.equipmentname.Name = "equipmentname";
            this.equipmentname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.equipmentname.Width = 150;
            // 
            // CgName
            // 
            this.CgName.DataPropertyName = "Cgname";
            this.CgName.HeaderText = "通信组名称";
            this.CgName.Name = "CgName";
            this.CgName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CgName.Width = 150;
            // 
            // StartAddRess
            // 
            this.StartAddRess.DataPropertyName = "startAddRess";
            this.StartAddRess.HeaderText = "起始地址";
            this.StartAddRess.Name = "StartAddRess";
            this.StartAddRess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartAddRess.Width = 150;
            // 
            // cglength
            // 
            this.cglength.DataPropertyName = "Cglength";
            this.cglength.HeaderText = "通信组长度";
            this.cglength.Name = "cglength";
            this.cglength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cglength.Width = 150;
            // 
            // ISenable
            // 
            this.ISenable.DataPropertyName = "isenable";
            this.ISenable.HeaderText = "是否启用";
            this.ISenable.Name = "ISenable";
            this.ISenable.Width = 150;
            // 
            // comments
            // 
            this.comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comments.DataPropertyName = "comments";
            this.comments.HeaderText = "备注";
            this.comments.Name = "comments";
            this.comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 791);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_CGroup);
            this.Controls.Add(this.btn_Add_CGroup);
            this.Controls.Add(this.chk_IsEnable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CGlength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_StartAddRess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_GroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_EquipmentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGroupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通信组管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGroupAdd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GroupName;
        private System.Windows.Forms.TextBox txt_StartAddRess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CGlength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_IsEnable;
        private System.Windows.Forms.Button btn_Add_CGroup;
        private System.Windows.Forms.DataGridView dgv_CGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddRess;
        private System.Windows.Forms.DataGridViewTextBoxColumn cglength;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISenable;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
    }
}