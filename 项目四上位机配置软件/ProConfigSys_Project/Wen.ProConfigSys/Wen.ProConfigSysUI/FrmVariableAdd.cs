using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wen.Models;
using Wen.Common;
using Wen.BLL;



namespace Wen.ProConfigSysUI
{
    //1、创建委托
    /// <summary>
    /// 发送变量
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public delegate void SendVariable(VariablesModel model);
    /// <summary>
    /// 发送修改之后的变量
    /// </summary>
    /// <param name="model"></param>
    public delegate void SendUpdateVariable(VariablesModel model);

    public partial class FrmVariableAdd : Form
    {
        //2、创建委托属性
        /// <summary>
        /// 发送变量委托属性
        /// </summary>
        public SendVariable SendVariable { get; set; }

        /// <summary>
        /// 发送修改变量属性
        /// </summary>
        public SendUpdateVariable SendUpdateVariable { get; set; }

        /// <summary>
        /// 变量属性
        /// </summary>
        public VariablesModel Var { get; set; } = new VariablesModel();

        /// <summary>
        /// 变量业务逻辑访问层
        /// </summary>
        public VariableBLL VariableBLL { get; set; } = new VariableBLL();

        /// <summary>
        /// 项目id
        /// </summary>
        public int ProjectId { get; set; } = 0;

        /// <summary>
        /// 通信组
        /// </summary>
        public CommunicationsgroupsModel Cgmodel { get; set; }=new CommunicationsgroupsModel();


        /// <summary>
        /// 判断变量配置/修改变量标志位
        /// </summary>
        public bool IsMordify = false;

        public FrmVariableAdd()
        {
            InitializeComponent();

            //初始化
            this.cmb_DataType.SelectedIndex = -1;

            this.lbl_CGname.Enabled = false;
            this.txt_AlarmMax.Enabled = false;
            this.txt_AlarmMax.BackColor = Color.Green;
            this.txt_AlarmMin.Enabled = false;
            this.txt_AlarmMin.BackColor = Color.Green;
            this.txt_AlarmMaxNode.BackColor = Color.Green;
            this.txt_AlarmMaxNode.Enabled = false;
            this.txt_AlarmMinNode.BackColor = Color.Green;
            this.txt_AlarmMinNode.Enabled = false;
        }

        /// <summary>
        /// 变量配置时使用的构造函数
        /// </summary>
        /// <param name="send"></param>
        /// <param name="cgId"></param>
        /// <param name="cgName"></param>
        public FrmVariableAdd(SendVariable send, CommunicationsgroupsModel  CgModel, int projectId) : this()
        {
            SendVariable = send;
            this.Cgmodel = CgModel;

            this.ProjectId = projectId;
            this.Var.Cgid = CgModel.Cgid;
            this.lbl_CGname.Text = CgModel.Cgname;

        }

        /// <summary>
        /// 修改变量时使用的构造函数
        /// </summary>
        /// <param name="model"></param>
        /// <param name="sendUpdate"></param>
        /// <param name="cgName"></param>
        public FrmVariableAdd(VariablesModel model, SendUpdateVariable sendUpdate, string cgName) : this()
        {
            //初始化
            this.lbl_CGname.Text = cgName;
            this.lbl_CGname.Enabled = false;
            this.Var = model;
            this.txt_VariableName.Text = model.Variablename;
            this.chk_IsMaxAlarm.Checked = model.Ismaxalarm;
            this.chk_IsMinAlarm.Checked = model.Isminalarm;
            if (this.chk_IsMaxAlarm.Checked)
            {
                this.txt_AlarmMax.Text = model.Alarmmax;
                this.txt_AlarmMaxNode.Text = model.AlarmMaxNode;
            }
            if (this.chk_IsMinAlarm.Checked)
            {
                this.txt_AlarmMax.Text = model.Alarmmin;
                this.txt_AlarmMinNode.Text = model.AlarmMinNode;
            }
            this.txt_StartAddress.Text = model.Startaddress;
            this.txt_Comments.Text = model.Comments;
            this.nud_Scale.Text = model.Scale;
            this.nud_OffsetorLength.Text = model.Offsetorlength;
            this.cmb_DataType.Text = model.Datatype;
            this.chk_IsFile.Checked = model.Isfile;

            this.btn_AddVariable.Text = "修改变量";
            this.IsMordify = true;

            SendUpdateVariable = sendUpdate;

            this.Var = model;
        }

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddVariable_Click(object sender, EventArgs e)
        {
            //数据验证
            #region  通用数据验证
            if (this.txt_VariableName.Text.ToString().Trim().Length <= 0)
            {
                MessageBox.Show("变量名为空", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txt_VariableName.Focus();
                return;
            }
            if (this.txt_StartAddress.Text.ToString().Trim().Length <= 0)
            {
                MessageBox.Show("起始地址为空", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txt_StartAddress.Focus();
                return;
            }
            if (this.chk_IsMaxAlarm.Checked == true)
            {
                if (this.txt_AlarmMax.Text.ToString().Trim().Length > 0)
                {
                    if (!DataValidate.IsIntegerOrFloat(this.txt_AlarmMax.Text))
                    {
                        MessageBox.Show("输入不为整数", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txt_AlarmMax.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("没有输入报警上限值", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txt_AlarmMax.Focus();
                    return;
                }
            }
            if (this.cmb_DataType.SelectedIndex < 0)
            {
                MessageBox.Show("没有选择数据类型", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cmb_DataType.Focus();
                return;
            }
            if (this.chk_IsMinAlarm.Checked == true)
            {
                if (this.txt_AlarmMin.Text.ToString().Trim().Length > 0)
                {
                    if (!DataValidate.IsIntegerOrFloat(this.txt_AlarmMin.Text))
                    {
                        MessageBox.Show("报警上限值输入不为整数", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txt_AlarmMax.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("没有输入报警上限值", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txt_AlarmMax.Focus();
                    return;
                }
            }
            if (this.txt_AlarmMax.Text.ToString().Trim().Length > 0 && this.txt_AlarmMin.Text.ToString().Trim().Length > 0)
            {
                if (Convert.ToInt32(this.txt_AlarmMax.Text.ToString()) <= Convert.ToInt32(this.txt_AlarmMin.Text.ToString()))
                {
                    MessageBox.Show("报警上限值小于或等于报警下限值", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txt_AlarmMax.Focus();
                    return;
                }
            }
            if (VariableBLL.VarNameIsAllowt(this.txt_VariableName.Text))
            {
                MessageBox.Show("变量名和通信组名称重复","变量配置",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                this.txt_VariableName.Focus();
                return;
            }
            #endregion

            //根据不同的数据类型，对线性值已经偏移量有不同的要求

            //封装对象
            this.Var.Variablename = this.txt_VariableName.Text;
            this.Var.Startaddress = this.txt_StartAddress.Text;
            this.Var.Comments = this.txt_Comments.Text;
            this.Var.Scale = this.nud_Scale.Text;
            this.Var.Offsetorlength = this.nud_OffsetorLength.Text;
            this.Var.Isfile = this.chk_IsFile.Checked;
            this.Var.Datatype = this.cmb_DataType.Text;

            this.Var.Ismaxalarm = this.chk_IsMaxAlarm.Checked;
            this.Var.Alarmmax = this.txt_AlarmMax.Text;
            this.Var.AlarmMaxNode = this.txt_AlarmMaxNode.Text;
            this.Var.Isminalarm = this.chk_IsMinAlarm.Checked;
            this.Var.Alarmmin = this.txt_AlarmMin.Text;
            this.Var.AlarmMinNode = this.txt_AlarmMinNode.Text;

            if (!this.IsMordify)
            {
                if (VariableBLL.IsRefareforInsert(this.ProjectId, this.txt_VariableName.Text))
                {
                    MessageBox.Show("变量名已存在", "变量配置", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txt_VariableName.Focus();
                    return;
                }
                //添加对象，返回数据
                int varId = this.VariableBLL.InsertVariable(this.Var);
                if (varId > 0)
                {
                    this.Var.Variableid = varId;
                    SendVariable(this.Var);
                }
            }
            //修改对象
            else
            {
                if (this.VariableBLL.IsRefareforUpdate(this.Var.Cgid, this.Var.Variableid, this.Var.Variablename))
                {
                    MessageBox.Show("变量名已存在","变量配置",MessageBoxButtons.OK,MessageBoxIcon.Stop);                    
                    this.txt_VariableName.Focus();
                    return;
                }
                if (this.VariableBLL.UpdateVariable(this.Var))
                {
                    SendUpdateVariable(this.Var);
                    this.DialogResult= DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// 每当变化时，最大报警值和最大报警备注显示相应变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_IsMaxAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_IsMaxAlarm.Checked)
            {
                this.txt_AlarmMax.BackColor = Color.White;
                this.txt_AlarmMax.Enabled = true;
                this.txt_AlarmMaxNode.BackColor = Color.White;
                this.txt_AlarmMaxNode.Enabled = true;
                this.txt_AlarmMaxNode.Text=this.txt_Comments.Text+"报警上限";
            }
            else
            {
                this.txt_AlarmMax.BackColor = Color.Green;
                this.txt_AlarmMax.Enabled = false;
                this.txt_AlarmMaxNode.BackColor = Color.Green;
                this.txt_AlarmMaxNode.Enabled = false;
                this.txt_AlarmMaxNode.Text=null;
            }
        }

        /// <summary>
        /// 每当变化时，最小报警值和最小报警备注显示相应变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_IsMinAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_IsMinAlarm.Checked)
            {
                this.txt_AlarmMin.BackColor = Color.White;
                this.txt_AlarmMin.Enabled = true;
                this.txt_AlarmMinNode.BackColor = Color.White;
                this.txt_AlarmMinNode.Enabled = true;
                this.txt_AlarmMinNode.Text=this.txt_Comments.Text+"报警下限";
            }
            else
            {
                this.txt_AlarmMin.BackColor = Color.Green;
                this.txt_AlarmMin.Enabled = false;
                this.txt_AlarmMinNode.BackColor = Color.Green;
                this.txt_AlarmMinNode.Enabled = false;
                this.txt_AlarmMinNode.Text=null;
            }
        }
    }
}
