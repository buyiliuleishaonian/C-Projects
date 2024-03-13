namespace Wen.ProConfigSysUI
{
    partial class FrmGroupUpadate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupUpadate));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EquipmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CGname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CGStartAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CGlength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.chk_Isenable = new System.Windows.Forms.CheckBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称：";
            // 
            // lbl_EquipmentName
            // 
            this.lbl_EquipmentName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_EquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_EquipmentName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_EquipmentName.Location = new System.Drawing.Point(149, 39);
            this.lbl_EquipmentName.Name = "lbl_EquipmentName";
            this.lbl_EquipmentName.Size = new System.Drawing.Size(295, 27);
            this.lbl_EquipmentName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "通信组名称：";
            // 
            // txt_CGname
            // 
            this.txt_CGname.Location = new System.Drawing.Point(149, 107);
            this.txt_CGname.Name = "txt_CGname";
            this.txt_CGname.Size = new System.Drawing.Size(295, 33);
            this.txt_CGname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "起始地址：";
            // 
            // txt_CGStartAddress
            // 
            this.txt_CGStartAddress.Location = new System.Drawing.Point(149, 179);
            this.txt_CGStartAddress.Name = "txt_CGStartAddress";
            this.txt_CGStartAddress.Size = new System.Drawing.Size(295, 33);
            this.txt_CGStartAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "通信组长度：";
            // 
            // txt_CGlength
            // 
            this.txt_CGlength.Location = new System.Drawing.Point(149, 249);
            this.txt_CGlength.Name = "txt_CGlength";
            this.txt_CGlength.Size = new System.Drawing.Size(295, 33);
            this.txt_CGlength.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(71, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "备注：";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(149, 319);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(376, 131);
            this.txt_Comments.TabIndex = 9;
            // 
            // chk_Isenable
            // 
            this.chk_Isenable.AutoSize = true;
            this.chk_Isenable.Location = new System.Drawing.Point(117, 472);
            this.chk_Isenable.Name = "chk_Isenable";
            this.chk_Isenable.Size = new System.Drawing.Size(107, 30);
            this.chk_Isenable.TabIndex = 10;
            this.chk_Isenable.Text = "是否启用";
            this.chk_Isenable.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Cyan;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Location = new System.Drawing.Point(311, 472);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(133, 46);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "修改通信组";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(450, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "请输录整数";
            // 
            // FrmGroupUpadate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 557);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.chk_Isenable);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CGlength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CGStartAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CGname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_EquipmentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGroupUpadate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通信组配置：修改通信组信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CGname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CGStartAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CGlength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.CheckBox chk_Isenable;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label7;
    }
}