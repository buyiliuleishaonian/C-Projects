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
    public partial class FrmGroupUpadate : Form
    {
        /// <summary>
        /// 通信组业务对象
        /// </summary>
        private CommunicationsGroupBLL CGBll { get; set; } = new CommunicationsGroupBLL();

        private int projectID;

        /// <summary>
        /// 通信组对象
        /// </summary>
        private CommunicationsgroupsModel CGmodel { get; set; } = new CommunicationsgroupsModel();

        public FrmGroupUpadate()
        {
            InitializeComponent();
        }

        public FrmGroupUpadate(CommunicationsgroupsModel model, int projectid) : this()
        {
            this.lbl_EquipmentName.Text = model.EquipmentName;
            this.lbl_EquipmentName.Enabled = false;
            this.txt_CGname.Text = model.Cgname;
            this.txt_CGStartAddress.Text = model.Startaddress;
            this.txt_CGlength.Text = model.Cglength.ToString();
            this.txt_Comments.Text = model.Comments;
            this.chk_Isenable.Checked = model.Isenable > 0 ? true : false;


            this.projectID = projectid;
            this.CGmodel= model;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txt_CGname.Text.Trim().Length <= 0)
            {
                MessageBox.Show("通信组名称为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_CGname.Focus();
                return;
            }
            if (this.txt_CGStartAddress.Text.Trim().Length <= 0)
            {
                MessageBox.Show("起始地址为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_CGStartAddress.Focus();
                return;
            }
            if (this.txt_CGlength.Text.Trim().Length <= 0)
            {
                MessageBox.Show("通信组长度为空", "添加通信组", MessageBoxButtons.OK);
                this.txt_CGlength.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txt_CGlength.Text))
            {
                MessageBox.Show("通信组长度不是正整数", "添加通信组", MessageBoxButtons.OK);
                this.txt_CGStartAddress.Focus();
                return;
            }
            //封装对象
            //CommunicationsgroupsModel model = new CommunicationsgroupsModel();
            //model.Cgname = this.txt_CGname.Text;
            //model.Startaddress = this.txt_CGStartAddress.Text;
            //model.Cglength = Convert.ToInt32(this.txt_CGlength.Text);
            //model.Comments = this.txt_Comments.Text;
            //model.Isenable = this.chk_Isenable.Checked == true ? 1 : 0;

            //model.Cgid = this.CGmodel.Cgid;
            //model.EquipmentName=this.lbl_EquipmentName.Text;

            //直接用接受通信组对象，所创建的通信组对象，此对象，就是对应了传过来List集合中对应的属性，这改变，对应集合中的元素也改变
            this.CGmodel.Cgname = this.txt_CGname.Text.Trim();
            this.CGmodel.Cglength = Convert.ToInt32(this.txt_CGlength.Text.Trim());
            this.CGmodel.Startaddress = this.txt_CGStartAddress.Text.Trim();
            this.CGmodel.Isenable = this.chk_Isenable.Checked == true ? 1 : 0;
            this.CGmodel.Comments = this.txt_Comments.Text.Trim();

            //添加对象
            if (this.CGBll.IsRepareForInsert(this.txt_CGname.Text, this.CGmodel.Equipmentid, this.projectID))
            {
                MessageBox.Show("通信组名称，在此设备类型中已存在", "通信组添加", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.txt_CGname.Focus();
                return;
            }
            try
            {
                bool result = this.CGBll.UpdateCommunicationGroup(this.CGmodel);
                if (result)
                {
                    this.Tag = this.CGmodel;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库返回错误" + ex.Message, "错误原因", MessageBoxButtons.OK);
            }
        }
    }
}
