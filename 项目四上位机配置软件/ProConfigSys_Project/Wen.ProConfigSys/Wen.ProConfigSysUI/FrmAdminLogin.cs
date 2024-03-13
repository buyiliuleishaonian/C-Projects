using IniHelperDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.BLL;
using Wen.Models;

namespace Wen.ProConfigSysUI
{
    public partial class FrmAdminLogin : Form
    {
        //登录用户对象
        public static SysadminsModel admin = new SysadminsModel();
        //用户对象的业务逻辑层
        public   SysAdminBLL adminBLL = new SysAdminBLL();
        //记住密码配置文件
        private string path = Application.StartupPath + @"\Decive\用户名.ini";

        public FrmAdminLogin()
        {

            InitializeComponent();
            //在初始化窗体之前，判断
            string value = IniConfigHelper.ReadIniData("记住密码", "是否启用", "", this.path);
            #region 方法一，判断配置文件Decive，之前是否勾选配置文件
            //if (value.ToLower() == "true" ? true : false)
            //{
            //    string user = IniConfigHelper.ReadIniData("用户账户", "账号", "", this.path);
            //    string pwd = IniConfigHelper.ReadIniData("用户密码", "密码", "", this.path);
            //    this.txtAccount.Text = user;
            //    this.txtAdminPwd.Text = pwd;
            //    this.chbSavepwd.Checked = true;
            //}
            #endregion

            #region 方法二，判断OBJ文件
            SysadminsModel adminmodel = adminBLL.ReadUser();
            if (adminmodel != null)
            {
                this.txtAccount.Text = adminmodel.Sysaccount;
                this.txtAdminPwd.Text = adminmodel.Adminpwd;
                this.chbSavepwd.Checked = true;
            }
            else
            {
                this.txtAccount.Text = string.Empty;
                this.txtAdminPwd.Text = string.Empty;
                this.chbSavepwd.Checked = false;
            }
            #endregion

        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region 移动无框窗体
        private Point point;
        /// <summary>
        /// 得到鼠标左键的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }
        /// <summary>
        /// 移动到鼠标左键拖动的地方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //修改窗体的位置，得到移动
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }
        #endregion

        /// <summary>
        /// 登录系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //需要先判断是否输录了用户名和密码
            if (this.txtAccount.Text == null || this.txtAccount.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("请输录用户名", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtAccount.Text = null;
                this.txtAccount.Focus();
                return;
            }
            if (this.txtAdminPwd.Text == null || this.txtAdminPwd.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("请输录密码", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtAdminPwd.Text = null;
                this.txtAdminPwd.Focus();
                return;
            }
            if (this.txtAdminPwd.Text.ToString().Trim().Length < 6 || this.txtAdminPwd.Text.ToString().Trim().Length > 18)
            {
                MessageBox.Show("密码长度不够，长度为6~18", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtAdminPwd.Focus();
                return;
            }
            admin.Sysaccount = this.txtAccount.Text;
            admin.Adminpwd = this.txtAdminPwd.Text;
            try
            {
                admin = adminBLL.SelectUser(admin);
                if (admin.Adminname != null)
                {
                    //如果项目中有其他的要求，可以在这里处理
                    //账号有效性，判断等等
                    //登入日志
                    //保存用户登入信息，方便下次自动输入
                    Program.Admin = admin;
                    //可以将其用户的密码和账号保存到文件里面去

                    #region  方法一保存密码

                    if (this.chbSavepwd.Checked == true)
                    {
                        if (!File.Exists(this.path))
                        {
                            //创建完就关闭
                            File.Create(this.path).Close();
                            IniConfigHelper.WriteIniData("用户账户", "账号", admin.Sysaccount, this.path);
                            IniConfigHelper.WriteIniData("用户密码", "密码", admin.Adminpwd, this.path);
                            IniConfigHelper.WriteIniData("记住密码", "是否启用", "true", this.path);
                        }
                        else
                        {
                            IniConfigHelper.WriteIniData("用户账户", "账号", admin.Sysaccount, this.path);
                            IniConfigHelper.WriteIniData("用户密码", "密码", admin.Adminpwd, this.path);
                            IniConfigHelper.WriteIniData("记住密码", "是否启用", "true", this.path);
                        }
                    }
                    else
                    {
                        IniConfigHelper.WriteIniData("记住密码", "是否启用", "false", this.path);
                    }
                    #endregion

                    #region 方法二，在数据访问层，通过文件流写入到文件中读取
                    if (this.chbSavepwd.Checked == true)
                    {
                        adminBLL.SaveUser(admin);
                    }
                    else
                    {
                        adminBLL.DeleteUser();
                    }
                    #endregion
                    this.DialogResult = MessageBox.Show("登录成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        }

        /// <summary>
        /// 按下回车键之后，登录用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
