using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Wen.BLL;
using Wen.Models;

namespace Wen.ProConfigSysUI
{
    public partial class FrmProject : Form
    {

        private ProjectsModel project = new ProjectsModel();

        private ProjectBLL projectBLL = new ProjectBLL();

        private string btnText=string.Empty;    

        public FrmProject(string name)
        {
            InitializeComponent();
            btnText = name;
        }

        /// <summary>
        /// 修改项目的构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        public FrmProject(string name,ProjectsModel model):this(name) 
        {
            project = model;
            if (project!=null)
            {
                this.btnAddProject.Text = btnText;
                this.txtProjectName.Text = project.Projectname;
            }
        }


        /// <summary>
        /// 添加项目名/重命名项目名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtProjectName.Text == null || this.txtProjectName.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("项目名为空", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //封装数据
            try
            {
                this.project.Projectname = this.txtProjectName.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool result=false;
            //调用业务
            if (btnText=="创建项目")
            {
                // 添加新项目
                 result= InsertProject();

            }
            if (btnText=="重命名")
            {
                 result = UpdateProject();
                project.Projectname = this.txtProjectName.Text;
            }

            if (result==true)
            {
                #region 方法二 通过窗体的Tag可以返回一个数据
                this.Tag = project;
                this.DialogResult = DialogResult.OK;
                #endregion
            }

        }

        #region  方法一 可以通过委托返回一个/所有Projects对象显示在dgvProjects上
        /// <summary>
        /// 通过委托 发送项目名的方法
        /// </summary>
        /// <returns></returns>
        public List<ProjectsModel> SendProject()
        {
            return projectBLL.SelectProject();
        }
        #endregion

        #region 添加项目
        /// <summary>
        /// 添加新项目
        /// </summary>
        public bool InsertProject()
        {
            //调用业务
            if (projectBLL.IsRepeatforInsert(project.Projectname))
            {
                MessageBox.Show("项目名已经存在，添加失败", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtProjectName.Text = string.Empty;
                this.txtProjectName.Focus();
                return false;
            }
            else
            {

                try
                {
                    project.Projectid = projectBLL.AddProjects(project);
                    if (project.Projectid > 0)
                    {
                        MessageBox.Show("添加成功", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("异常原因" + ex.Message, "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("异常原因" + ex.Message, "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                return false;
            }
        }
        #endregion

        #region 重命名项目
        /// <summary>
        /// 重命名项目
        /// </summary>
        public bool UpdateProject()
        {
            if (projectBLL.IsRepeatforUpdate(project))
            {
                MessageBox.Show("修改之后的项目名，已重复存在", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtProjectName.Focus();
                return false;
            }
            try
            {
                int num = projectBLL.UpdateProject(project);
                if (num > 0)
                {
                    MessageBox.Show("修改成功", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("异常原因" + ex.Message, "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常原因" + ex.Message, "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return false;
        }
        #endregion
    }
}
