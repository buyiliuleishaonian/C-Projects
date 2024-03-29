﻿namespace 学生管理UI
{
    partial class FrmScoreManage
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreManage));
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStat = new System.Windows.Forms.GroupBox();
            this.lblDBAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCSharpAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.ListBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServerDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.gbStat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvScoreList.ColumnHeadersHeight = 29;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.ClassName,
            this.CSharp,
            this.SQLServerDB});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.Location = new System.Drawing.Point(16, 144);
            this.dgvScoreList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            this.dgvScoreList.RowHeadersWidth = 51;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(672, 402);
            this.dgvScoreList.TabIndex = 7;
            this.dgvScoreList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvScoreList_CellFormatting);
            this.dgvScoreList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvScoreList_RowPostPaint);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(125, 94);
            this.cboClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(160, 23);
            this.cboClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "学员班级：";
            // 
            // gbStat
            // 
            this.gbStat.Controls.Add(this.lblDBAvg);
            this.gbStat.Controls.Add(this.label8);
            this.gbStat.Controls.Add(this.lblCount);
            this.gbStat.Controls.Add(this.lblCSharpAvg);
            this.gbStat.Controls.Add(this.label4);
            this.gbStat.Controls.Add(this.label6);
            this.gbStat.Controls.Add(this.lblAttendCount);
            this.gbStat.Controls.Add(this.label3);
            this.gbStat.Location = new System.Drawing.Point(696, 144);
            this.gbStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStat.Name = "gbStat";
            this.gbStat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStat.Size = new System.Drawing.Size(221, 402);
            this.gbStat.TabIndex = 10;
            this.gbStat.TabStop = false;
            this.gbStat.Text = "考试成绩统计";
            // 
            // lblDBAvg
            // 
            this.lblDBAvg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDBAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDBAvg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDBAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDBAvg.Location = new System.Drawing.Point(120, 219);
            this.lblDBAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDBAvg.Name = "lblDBAvg";
            this.lblDBAvg.Size = new System.Drawing.Size(81, 29);
            this.lblDBAvg.TabIndex = 12;
            this.lblDBAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "DB平均分：";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(120, 102);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(81, 29);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCSharpAvg
            // 
            this.lblCSharpAvg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSharpAvg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCSharpAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCSharpAvg.Location = new System.Drawing.Point(120, 159);
            this.lblCSharpAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCSharpAvg.Name = "lblCSharpAvg";
            this.lblCSharpAvg.Size = new System.Drawing.Size(81, 29);
            this.lblCSharpAvg.TabIndex = 12;
            this.lblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "缺考总人数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "C#平均分：";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAttendCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAttendCount.Location = new System.Drawing.Point(120, 41);
            this.lblAttendCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(81, 29);
            this.lblAttendCount.TabIndex = 12;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "参考总人数：";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.ItemHeight = 15;
            this.lblList.Location = new System.Drawing.Point(15, 34);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(179, 349);
            this.lblList.TabIndex = 13;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(465, 94);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(223, 29);
            this.btnStat.TabIndex = 15;
            this.btnStat.Text = "统计全校考试信息";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 42);
            this.label9.TabIndex = 16;
            this.label9.Text = "学员成绩管理";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1011, 85);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblList);
            this.groupBox1.Location = new System.Drawing.Point(925, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(211, 409);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "缺考人员列表";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "objstu";
            this.StudentId.HeaderText = "学号";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "objstu";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "Objclass";
            this.ClassName.HeaderText = "班级";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 125;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "objsco";
            this.CSharp.HeaderText = "C#成绩";
            this.CSharp.MinimumWidth = 6;
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            this.CSharp.Width = 80;
            // 
            // SQLServerDB
            // 
            this.SQLServerDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SQLServerDB.DataPropertyName = "objsco";
            this.SQLServerDB.HeaderText = "数据库成绩";
            this.SQLServerDB.MinimumWidth = 6;
            this.SQLServerDB.Name = "SQLServerDB";
            this.SQLServerDB.ReadOnly = true;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.gbStat);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScoreManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.gbStat.ResumeLayout(false);
            this.gbStat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStat;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDBAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCSharpAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lblList;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServerDB;
    }
}