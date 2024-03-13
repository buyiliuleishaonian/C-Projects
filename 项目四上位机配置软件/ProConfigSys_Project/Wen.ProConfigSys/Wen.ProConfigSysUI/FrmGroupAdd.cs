using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wen.BLL;
using Wen.Common;
using Wen.Models;

namespace Wen.ProConfigSysUI
{
    public partial class FrmGroupAdd : Form
    {
        /// <summary>
        /// 通信组业务逻辑属性
        /// </summary>
        private CommunicationsGroupBLL CGroup { get; set; } = new CommunicationsGroupBLL();

        /// <summary>
        /// 通信组对象
        /// </summary>
        private CommunicationsgroupsModel Cgroup { get; set; } = new CommunicationsgroupsModel();

        /// <summary>
        /// 通信组集合
        /// </summary>
        public List<CommunicationsgroupsModel> CGroupList { get; set; }= new List<CommunicationsgroupsModel>();

        /// <summary>
        /// 项目ID
        /// </summary>
        int projectid;

        public FrmGroupAdd()
        {
            InitializeComponent();
            //初始化dgv_CGroup
            this.dgv_CGroup.AutoGenerateColumns = false;
        }

        public FrmGroupAdd(string equipmentName, int equipmentID,List<CommunicationsgroupsModel> list, int projectid) : this()
        {
            this.lbl_EquipmentName.Text = equipmentName;
            Cgroup.Equipmentid = equipmentID;
            Cgroup.EquipmentName = equipmentName;
            this.CGroupList = list;
            this.dgv_CGroup.DataSource = null;
            this.dgv_CGroup.DataSource = this.CGroupList;
            this.projectid = projectid;
        }

        private void btn_Add_CGroup_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txt_GroupName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("通信组名称为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_GroupName.Focus();
                return;
            }
            if (this.txt_StartAddRess.Text.Trim().Length <= 0)
            {
                MessageBox.Show("起始地址为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_StartAddRess.Focus();
                return;
            }
            if (this.txt_CGlength.Text.Trim().Length <= 0)
            {
                MessageBox.Show("通信组长度为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_StartAddRess.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txt_CGlength.Text))
            {
                MessageBox.Show("通信组长度不是正整数", "添加通信组", MessageBoxButtons.OK);
                this.txt_StartAddRess.Focus();
                return;
            }
            //封装对象
            CommunicationsgroupsModel model = new CommunicationsgroupsModel();
            model.Cgname = this.txt_GroupName.Text;
            model.Startaddress = this.txt_StartAddRess.Text;
            model.Cglength = Convert.ToInt32(this.txt_CGlength.Text);
            model.Comments = this.txt_Comments.Text;
            model.Isenable = this.chk_IsEnable.Checked == true ? 1 : 0;

            model.Equipmentid = Cgroup.Equipmentid;

            model.EquipmentName=this.lbl_EquipmentName.Text;    

            //添加对象
            if (CGroup.IsRepareForInsert(model.Cgname, model.Equipmentid,this.projectid))
            {
                MessageBox.Show("通信组名称，在此设备类型中已存在", "通信组添加", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.txt_GroupName.Focus();
                return;
            }

            try
            {
                int num = CGroup.InsertCommunication(model);
                if (num > 0)
                {
                    MessageBox.Show("添加成功", "通信组设置", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    model.Cgid = num;
                    model.SN = this.CGroupList.Count + 1;
                    CGroupList.Add(model);
                }
                //返回数据

                //清空数据，现在Dgv中
                this.txt_GroupName.Text = string.Empty;
                this.txt_StartAddRess.Text = string.Empty;
                this.txt_CGlength.Text = string.Empty;
                this.txt_Comments.Text = string.Empty;
                this.chk_IsEnable.Checked = false;

                this.dgv_CGroup.DataSource = null;
                this.dgv_CGroup.DataSource = this.CGroupList;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("数据库添加错误"+ex.Message,"通信组添加错误",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

        }

        private void FrmGroupAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Tag = this.CGroupList;
        }
    }
}
