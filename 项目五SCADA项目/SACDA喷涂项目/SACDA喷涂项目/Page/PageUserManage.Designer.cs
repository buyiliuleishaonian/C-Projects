namespace SACDA喷涂项目
{
    partial class PageUserManage
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
            uiLabel1 = new Sunny.UI.UILabel();
            txt_UserName = new Sunny.UI.UITextBox();
            txt_UserPwd = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txt_EnterPassword = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            cb_Auth = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            btn_AddUser = new Sunny.UI.UISymbolButton();
            btn_UpdateUser = new Sunny.UI.UISymbolButton();
            btn_DelUser = new Sunny.UI.UISymbolButton();
            dgv_User = new Sunny.UI.UIDataGridView();
            ID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            UserPwd = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(27, 44);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(84, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "用户名称";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_UserName.Location = new Point(130, 44);
            txt_UserName.Margin = new Padding(4, 5, 4, 5);
            txt_UserName.MinimumSize = new Size(1, 16);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Padding = new Padding(5);
            txt_UserName.ShowText = false;
            txt_UserName.Size = new Size(150, 29);
            txt_UserName.TabIndex = 1;
            txt_UserName.TextAlignment = ContentAlignment.MiddleCenter;
            txt_UserName.Watermark = "用户名称";
            // 
            // txt_UserPwd
            // 
            txt_UserPwd.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_UserPwd.Location = new Point(130, 102);
            txt_UserPwd.Margin = new Padding(4, 5, 4, 5);
            txt_UserPwd.MinimumSize = new Size(1, 16);
            txt_UserPwd.Name = "txt_UserPwd";
            txt_UserPwd.Padding = new Padding(5);
            txt_UserPwd.ShowText = false;
            txt_UserPwd.Size = new Size(150, 29);
            txt_UserPwd.TabIndex = 3;
            txt_UserPwd.TextAlignment = ContentAlignment.MiddleCenter;
            txt_UserPwd.Watermark = "用户密码";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(27, 102);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(84, 23);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "用户密码";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_EnterPassword
            // 
            txt_EnterPassword.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_EnterPassword.Location = new Point(130, 154);
            txt_EnterPassword.Margin = new Padding(4, 5, 4, 5);
            txt_EnterPassword.MinimumSize = new Size(1, 16);
            txt_EnterPassword.Name = "txt_EnterPassword";
            txt_EnterPassword.Padding = new Padding(5);
            txt_EnterPassword.ShowText = false;
            txt_EnterPassword.Size = new Size(150, 29);
            txt_EnterPassword.TabIndex = 4;
            txt_EnterPassword.TextAlignment = ContentAlignment.MiddleCenter;
            txt_EnterPassword.Watermark = "确认密码";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(27, 160);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(84, 23);
            uiLabel3.TabIndex = 3;
            uiLabel3.Text = "确认密码";
            uiLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_Auth
            // 
            cb_Auth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cb_Auth.Location = new Point(130, 218);
            cb_Auth.Margin = new Padding(4, 5, 4, 5);
            cb_Auth.MinimumSize = new Size(1, 16);
            cb_Auth.Name = "cb_Auth";
            cb_Auth.Padding = new Padding(5);
            cb_Auth.ShowText = false;
            cb_Auth.Size = new Size(150, 29);
            cb_Auth.TabIndex = 4;
            cb_Auth.TextAlignment = ContentAlignment.MiddleCenter;
            cb_Auth.Watermark = "权限选择";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(27, 218);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(84, 23);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "权限选择";
            uiLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_AddUser
            // 
            btn_AddUser.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_AddUser.Location = new Point(27, 303);
            btn_AddUser.MinimumSize = new Size(1, 1);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(182, 32);
            btn_AddUser.Symbol = 561285;
            btn_AddUser.TabIndex = 5;
            btn_AddUser.Text = "添加用户";
            btn_AddUser.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_UpdateUser
            // 
            btn_UpdateUser.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_UpdateUser.Location = new Point(27, 371);
            btn_UpdateUser.MinimumSize = new Size(1, 1);
            btn_UpdateUser.Name = "btn_UpdateUser";
            btn_UpdateUser.Size = new Size(182, 32);
            btn_UpdateUser.Symbol = 362719;
            btn_UpdateUser.TabIndex = 6;
            btn_UpdateUser.Text = "修改用户";
            btn_UpdateUser.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // btn_DelUser
            // 
            btn_DelUser.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_DelUser.Location = new Point(27, 439);
            btn_DelUser.MinimumSize = new Size(1, 1);
            btn_DelUser.Name = "btn_DelUser";
            btn_DelUser.Size = new Size(182, 32);
            btn_DelUser.Symbol = 561286;
            btn_DelUser.TabIndex = 7;
            btn_DelUser.Text = "删除用户";
            btn_DelUser.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // dgv_User
            // 
            dgv_User.AllowUserToAddRows = false;
            dgv_User.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_User.BackgroundColor = Color.White;
            dgv_User.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_User.ColumnHeadersHeight = 32;
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_User.Columns.AddRange(new DataGridViewColumn[] { ID, UserName, UserPwd, Role });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_User.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_User.EnableHeadersVisualStyles = false;
            dgv_User.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_User.GridColor = Color.FromArgb(80, 160, 255);
            dgv_User.Location = new Point(319, 12);
            dgv_User.Name = "dgv_User";
            dgv_User.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_User.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv_User.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_User.SelectedIndex = -1;
            dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_User.Size = new Size(741, 507);
            dgv_User.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_User.TabIndex = 8;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "用户名";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 200;
            // 
            // UserPwd
            // 
            UserPwd.HeaderText = "密码";
            UserPwd.Name = "UserPwd";
            UserPwd.ReadOnly = true;
            UserPwd.Width = 200;
            // 
            // Role
            // 
            Role.HeaderText = "角色";
            Role.Name = "Role";
            Role.ReadOnly = true;
            Role.Width = 200;
            // 
            // PageUserManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(dgv_User);
            Controls.Add(btn_DelUser);
            Controls.Add(btn_UpdateUser);
            Controls.Add(btn_AddUser);
            Controls.Add(cb_Auth);
            Controls.Add(uiLabel4);
            Controls.Add(txt_EnterPassword);
            Controls.Add(uiLabel3);
            Controls.Add(txt_UserPwd);
            Controls.Add(uiLabel2);
            Controls.Add(txt_UserName);
            Controls.Add(uiLabel1);
            Name = "PageUserManage";
            Symbol = 61447;
            Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_UserName;
        private Sunny.UI.UITextBox txt_UserPwd;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_EnterPassword;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox cb_Auth;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton btn_AddUser;
        private Sunny.UI.UISymbolButton btn_UpdateUser;
        private Sunny.UI.UISymbolButton btn_DelUser;
        private Sunny.UI.UIDataGridView dgv_User;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserPwd;
        private DataGridViewTextBoxColumn Role;
    }
}