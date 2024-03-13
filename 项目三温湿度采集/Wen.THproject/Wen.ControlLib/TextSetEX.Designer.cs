﻿namespace Wen.ControlLib
{
    partial class TextSetEX 
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.num_Value = new System.Windows.Forms.NumericUpDown();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_Unit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_Value, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(174, 40);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "1#号站点温度高限";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Value
            // 
            this.num_Value.DecimalPlaces = 1;
            this.num_Value.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.num_Value.Location = new System.Drawing.Point(183, 6);
            this.num_Value.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.num_Value.Name = "num_Value";
            this.num_Value.Size = new System.Drawing.Size(80, 27);
            this.num_Value.TabIndex = 2;
            this.num_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Unit.Location = new System.Drawing.Point(269, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(48, 40);
            this.lbl_Unit.TabIndex = 3;
            this.lbl_Unit.Text = "℃";
            this.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextSetEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextSetEX";
            this.Size = new System.Drawing.Size(320, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.NumericUpDown num_Value;
    }
}
