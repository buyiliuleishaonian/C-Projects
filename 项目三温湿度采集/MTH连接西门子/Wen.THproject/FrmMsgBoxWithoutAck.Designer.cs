﻿namespace Wen.THproject
{
    partial class FrmMsgBoxWithoutAck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsgBoxWithoutAck));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(1, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(131, 52);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "通信组设置";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(334, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 41);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Text
            // 
            this.lbl_Text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Text.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Text.Location = new System.Drawing.Point(0, 81);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(377, 52);
            this.lbl_Text.TabIndex = 8;
            this.lbl_Text.Text = "通信组设置";
            this.lbl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OK.Location = new System.Drawing.Point(47, 149);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(290, 41);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // FrmMsgBoxWithoutAck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Wen.THproject.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(380, 224);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMsgBoxWithoutAck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMsgBoxWithAck";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Button btn_OK;
    }
}