namespace SACDA喷涂项目
{
    partial class PageAuthManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAuthManage));
            btn_UpdateVisitorAuth = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            btn_UpdateEngAuth = new Sunny.UI.UIButton();
            cbg_Visitor = new Sunny.UI.UICheckBoxGroup();
            cbg_Operate = new Sunny.UI.UICheckBoxGroup();
            cbg_Engineer = new Sunny.UI.UICheckBoxGroup();
            SuspendLayout();
            // 
            // btn_UpdateVisitorAuth
            // 
            btn_UpdateVisitorAuth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_UpdateVisitorAuth.Location = new Point(854, 362);
            btn_UpdateVisitorAuth.MinimumSize = new Size(1, 1);
            btn_UpdateVisitorAuth.Name = "btn_UpdateVisitorAuth";
            btn_UpdateVisitorAuth.Size = new Size(200, 91);
            btn_UpdateVisitorAuth.TabIndex = 10;
            btn_UpdateVisitorAuth.Text = "修改访客权限";
            btn_UpdateVisitorAuth.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(854, 239);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(200, 91);
            uiButton1.TabIndex = 9;
            uiButton1.Text = "修改操作员权限";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_UpdateEngAuth
            // 
            btn_UpdateEngAuth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_UpdateEngAuth.Location = new Point(854, 115);
            btn_UpdateEngAuth.MinimumSize = new Size(1, 1);
            btn_UpdateEngAuth.Name = "btn_UpdateEngAuth";
            btn_UpdateEngAuth.Size = new Size(200, 91);
            btn_UpdateEngAuth.TabIndex = 8;
            btn_UpdateEngAuth.Text = "修改工程师权限";
            btn_UpdateEngAuth.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // cbg_Visitor
            // 
            cbg_Visitor.CheckBoxSize = 25;
            cbg_Visitor.ColumnInterval = 20;
            cbg_Visitor.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbg_Visitor.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图标模块", "参数模块" });
            cbg_Visitor.Location = new Point(587, 85);
            cbg_Visitor.Margin = new Padding(4, 5, 4, 5);
            cbg_Visitor.MinimumSize = new Size(1, 1);
            cbg_Visitor.Name = "cbg_Visitor";
            cbg_Visitor.Padding = new Padding(0, 46, 0, 0);
            cbg_Visitor.RowInterval = 15;
            cbg_Visitor.SelectedIndexes = (List<int>)resources.GetObject("cbg_Visitor.SelectedIndexes");
            cbg_Visitor.Size = new Size(231, 378);
            cbg_Visitor.StartPos = new Point(30, 30);
            cbg_Visitor.TabIndex = 6;
            cbg_Visitor.Text = "访客权限";
            cbg_Visitor.TextAlignment = ContentAlignment.TopLeft;
            cbg_Visitor.TitleInterval = 35;
            cbg_Visitor.TitleTop = 30;
            // 
            // cbg_Operate
            // 
            cbg_Operate.CheckBoxSize = 25;
            cbg_Operate.ColumnInterval = 20;
            cbg_Operate.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbg_Operate.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图标模块", "参数模块" });
            cbg_Operate.Location = new Point(309, 85);
            cbg_Operate.Margin = new Padding(4, 5, 4, 5);
            cbg_Operate.MinimumSize = new Size(1, 1);
            cbg_Operate.Name = "cbg_Operate";
            cbg_Operate.Padding = new Padding(0, 46, 0, 0);
            cbg_Operate.RowInterval = 15;
            cbg_Operate.SelectedIndexes = (List<int>)resources.GetObject("cbg_Operate.SelectedIndexes");
            cbg_Operate.Size = new Size(231, 378);
            cbg_Operate.StartPos = new Point(30, 30);
            cbg_Operate.TabIndex = 7;
            cbg_Operate.Text = "操作员权限";
            cbg_Operate.TextAlignment = ContentAlignment.TopLeft;
            cbg_Operate.TitleInterval = 35;
            cbg_Operate.TitleTop = 30;
            // 
            // cbg_Engineer
            // 
            cbg_Engineer.CheckBoxSize = 25;
            cbg_Engineer.ColumnInterval = 20;
            cbg_Engineer.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbg_Engineer.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图标模块", "参数模块" });
            cbg_Engineer.Location = new Point(30, 85);
            cbg_Engineer.Margin = new Padding(4, 5, 4, 5);
            cbg_Engineer.MinimumSize = new Size(1, 1);
            cbg_Engineer.Name = "cbg_Engineer";
            cbg_Engineer.Padding = new Padding(0, 46, 0, 0);
            cbg_Engineer.RowInterval = 15;
            cbg_Engineer.SelectedIndexes = (List<int>)resources.GetObject("cbg_Engineer.SelectedIndexes");
            cbg_Engineer.Size = new Size(231, 378);
            cbg_Engineer.StartPos = new Point(30, 30);
            cbg_Engineer.TabIndex = 5;
            cbg_Engineer.Text = "工程师权限";
            cbg_Engineer.TextAlignment = ContentAlignment.TopLeft;
            cbg_Engineer.TitleInterval = 35;
            cbg_Engineer.TitleTop = 30;
            // 
            // PageAuthManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(btn_UpdateVisitorAuth);
            Controls.Add(uiButton1);
            Controls.Add(btn_UpdateEngAuth);
            Controls.Add(cbg_Visitor);
            Controls.Add(cbg_Operate);
            Controls.Add(cbg_Engineer);
            Name = "PageAuthManage";
            Symbol = 362722;
            Text = "权限管理";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btn_UpdateVisitorAuth;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btn_UpdateEngAuth;
        private Sunny.UI.UICheckBoxGroup cbg_Visitor;
        private Sunny.UI.UICheckBoxGroup cbg_Operate;
        private Sunny.UI.UICheckBoxGroup cbg_Engineer;
    }
}