using MiniExcelLibs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.BLL;
using Wen.Common;
using Wen.Models;
using Wen.ComonHelper;

using ConfigLib;
using System.IO;
using CommonHelper;
using DataGridViewStyle = Wen.Common.DataGridViewStyle;
using System.Diagnostics;

namespace Wen.ProConfigSysUI
{

    public partial class FrmMain : Form
    {
        /// <summary>
        /// 项目逻辑层
        /// </summary>
        private ProjectBLL projectBll { get; set; } = new ProjectBLL();

        /// <summary>
        /// 设备逻辑层
        /// </summary> 
        private EquipMentBLL equBLL { get; set; } = new EquipMentBLL();

        /// <summary>
        /// 项目的泛型集合
        /// </summary>
        public List<ProjectsModel> proList { get; set; } = new List<ProjectsModel>();

        /// <summary>
        /// 项目——对应设备类型
        /// </summary>
        public Dictionary<int, List<EquipmentsModel>> equDic = new Dictionary<int, List<EquipmentsModel>>();

        /// <summary>
        /// 通信组集合
        /// </summary>
        public List<CommunicationsgroupsModel> CGroupList { get; set; } = new List<CommunicationsgroupsModel>();

        /// <summary>
        /// 通信组业务逻辑对象
        /// </summary>
        public CommunicationsGroupBLL CGBLL { get; set; } = new CommunicationsGroupBLL();

        /// <summary>
        /// 变量集合
        /// </summary>
        public List<VariablesModel> VarList { get; set; } = new List<VariablesModel>();

        /// <summary>
        /// 变量业务逻辑对象
        /// </summary>
        public VariableBLL Variablebll { get; set; } = new VariableBLL();

        #region 用于不同类型设备的泛型集合
        /// <summary>
        /// ip类型设备
        /// </summary>
        public List<EquipmentsModel> equIPAddRess = new List<EquipmentsModel>();

        /// <summary>
        /// 串口类型设备
        /// </summary>
        public List<EquipmentsModel> equSerial = new List<EquipmentsModel>();

        /// <summary>
        /// OPC类型涉笔
        /// </summary>
        public List<EquipmentsModel> equOPC = new List<EquipmentsModel>();
        #endregion

        /// <summary>
        /// 初始化主窗体
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            //初始化登入用户名
            this.tlbleUser.Text = FrmAdminLogin.admin.Adminname;

            //初始化dgvProjects
            this.dgvProjects.AutoGenerateColumns = false;
            this.dgvProjects.DataSource = null;
            //初始化dgv_Equipment
            this.dgv_EquipMent_IPAddRess.AutoGenerateColumns = false;
            this.dgv_EquipMnetProt_SerialNo.AutoGenerateColumns = false;
            this.dgv_EquipMent_OPC.AutoGenerateColumns = false;
            //取消默认选择第一行/第一单元格
            this.dgv_EquipMent_IPAddRess.ClearSelection();
            this.dgv_EquipMnetProt_SerialNo.ClearSelection();
            this.dgv_EquipMent_OPC.ClearSelection();
            //初始化dgv_CGroup和dgv_Variable
            this.dgv_CG.AutoGenerateColumns = false;
            this.dgv_Variable.AutoGenerateColumns = false;

            //查询是否在存在项目
            proList = projectBll.SelectProject();
            //当项目里面不存在项目数据，重命名和删除按钮不可用
            if (proList.Count == 0)
            {
                this.btnUpdataProjectName.Enabled = false;
                this.btnDeleteProject.Enabled = false;
            }
            else
            {
                //如果集合中没有数据，就不要绑定，否则会出现错误！索引-1处没有值
                this.dgvProjects.DataSource = proList;

                this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            }
        }

        /// <summary>
        /// 窗体关闭前确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出程序", "程序退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        #region  项目的增删改（随着设备，通信组，变量编写，项目的增删改也会影响这些），在数据库中设定级联删除，就可以在删除父键的情况下删除自建

        /// <summary>
        /// 弹出项目创建的对话框，来实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            FrmProject frm = new FrmProject(this.btnNewProject.Text);
            //表示这个窗体没有完结之前，无法进行其他操作
            //此时需要进行一个跨窗体的传值
            DialogResult result = frm.ShowDialog();
            #region  方法一 通过委托得到项目窗体返回的值
            //RV += frm.SendProject;
            //if (frm.DialogResult == DialogResult.OK)
            //{

            //}
            #endregion

            #region 方法二，通过窗体的tag返回数据
            if (result == DialogResult.OK)
            {
                ProjectsModel model = (ProjectsModel)frm.Tag;
                model.SN = this.proList.Count + 1;
                proList.Add(model);
                this.dgvProjects.DataSource = null;
                //proList = projectBll.SelectProject();
                this.dgvProjects.DataSource = proList;
            }
            #endregion
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdataProjectName_Click(object sender, EventArgs e)
        {
            ProjectsModel model = new ProjectsModel();
            model = proList[Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["SN"].Value) - 1];
            FrmProject frm = new FrmProject(this.btnUpdataProjectName.Text, model);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                proList[Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["SN"].Value) - 1].Projectname =
                    ((ProjectsModel)frm.Tag).Projectname;
                this.dgvProjects.DataSource = null;
                this.dgvProjects.DataSource = proList;
            }
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            //验证是否有项目数据
            if (this.dgvProjects.Rows.Count > 0)
            {
                int numID = Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["projectid"].Value);
                int num = projectBll.DeleteProjects(numID);
                //确认删除
                DialogResult result = MessageBox.Show("删除当前选中的项目吗？删除时会同时吧所有设备，通信组，变量消息一同删除", "删除警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    proList = projectBll.SelectProject();
                    this.dgvProjects.DataSource = null;
                    if (this.proList.Count != 0)
                    {
                        //如果集合为空，就不将数据给到DataGrid，否则报错索引-1，没有值
                        this.dgvProjects.DataSource = proList;
                    }
                    MessageBox.Show("删除成功", "项目配置", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.dgv_EquipMent_IPAddRess.DataSource = null;
                    this.dgv_EquipMnetProt_SerialNo.DataSource = null;
                    this.dgv_EquipMent_OPC.DataSource = null;
                    this.dgv_CG.DataSource = null;
                    this.dgv_Variable.DataSource = null;
                }
            }
        }

        /// <summary>
        /// 项目数据变化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProjects_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dgvProjects.DataSource != null)
            {
                this.btnUpdataProjectName.Enabled = true;
                this.btnDeleteProject.Enabled = true;
            }
            else
            {
                this.btnUpdataProjectName.Enabled = false;
                this.btnDeleteProject.Enabled = false;
            }
        }


        #endregion


        #region 设备类型的增删改查

        #region 添加设备

        /// <summary>
        /// 添加设备类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEquipMents_Click(object sender, EventArgs e)
        {
            //判断是否存在项目
            if (this.dgvProjects.Rows.Count == 0)
            {
                MessageBox.Show("请首先添加项目", "配置设备", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            ProjectsModel model = new ProjectsModel();
            model = this.proList[this.dgvProjects.CurrentRow.Index];
            FrmEquipMent frm = new FrmEquipMent(model);
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                EquipmentsModel equ = (EquipmentsModel)frm.Tag;
                switch (equ.Etypeid)
                {
                    case 10:
                        equ.SN = this.dgv_EquipMent_IPAddRess.Rows.Count + 1;
                        equIPAddRess.Add(equ);
                        this.dgv_EquipMent_IPAddRess.DataSource = null;
                        this.dgv_EquipMent_IPAddRess.DataSource = equIPAddRess;
                        break;
                    case 11:
                        equ.SN = this.dgv_EquipMnetProt_SerialNo.Rows.Count + 1;
                        equSerial.Add(equ);
                        this.dgv_EquipMnetProt_SerialNo.DataSource = null;
                        this.dgv_EquipMnetProt_SerialNo.DataSource = equSerial;
                        break;
                    case 12:
                        equ.SN = this.dgv_EquipMent_OPC.Rows.Count + 1;
                        equOPC.Add(equ);
                        this.dgv_EquipMent_OPC.DataSource = null;
                        this.dgv_EquipMent_OPC.DataSource = equOPC;
                        break;
                    default:
                        break;
                }
                //在这里Project的外键List<EquipMentModel>也要得到对应添加
                this.proList[this.dgvProjects.CurrentRow.Index].EquipmentMoedelList.Add(equ);
            }
        }
        #endregion

        #region 修改设备

        /// <summary>
        /// 修改以太网设备类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsml_Update_Internet_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_IPAddRess.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["equipmentid"].Value.ToString());
            ShowUpdateEquipMent(this.dgv_EquipMent_IPAddRess, this.equIPAddRess, num);
        }

        /// <summary>
        /// 修改窗口设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsml_Update_SerialPort_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMnetProt_SerialNo.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["equipmentid2"].Value.ToString());
            ShowUpdateEquipMent(this.dgv_EquipMnetProt_SerialNo, this.equSerial, num);
        }

        /// <summary>
        /// 修改OPC设备类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsml_Update_OPC_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_OPC.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMent_OPC.CurrentRow.Cells["equipmentid3"].Value.ToString());
            ShowUpdateEquipMent(this.dgv_EquipMent_OPC, this.equOPC, num);
        }

        /// <summary>
        /// 所选项目更改之后，对应的设备类型需要更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvProjects.Rows.Count > 0)
            {
                int num = Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["projectid"].Value.ToString());

                this.equDic = equBLL.QueryEquipments(num);
                //需要同步将设备，通信组，列表清空
                this.equIPAddRess.Clear();
                this.equSerial.Clear();
                this.equOPC.Clear();

                for (int i = 0; i < equDic[10].Count; i++)
                {
                    this.equIPAddRess.Add(equDic[10][i]);
                }
                for (int i = 0; i < equDic[11].Count; i++)
                {
                    this.equSerial.Add(equDic[11][i]);
                }
                for (int i = 0; i < equDic[12].Count; i++)
                {
                    this.equOPC.Add(equDic[12][i]);
                }
                this.dgv_EquipMent_IPAddRess.DataSource = null;
                this.dgv_EquipMnetProt_SerialNo.DataSource = null;
                this.dgv_EquipMent_OPC.DataSource = null;

                this.dgv_CG.DataSource = null;
                this.dgv_Variable.DataSource = null;

                this.dgv_EquipMent_IPAddRess.DataSource = this.equIPAddRess;
                this.dgv_EquipMnetProt_SerialNo.DataSource = this.equSerial;
                this.dgv_EquipMent_OPC.DataSource = this.equOPC;

                //取消默认选择第一行/第一个单元格
                this.dgv_EquipMent_IPAddRess.ClearSelection();
                this.dgv_EquipMnetProt_SerialNo.ClearSelection();
                this.dgv_EquipMent_OPC.ClearSelection();
            }
        }

        /// <summary>
        /// 修改设备类型通用方法
        /// </summary>
        /// <param name="dgv">设备类型table控件</param>
        /// <param name="equModel">设备类型集合</param>
        private void ShowUpdateEquipMent(DataGridView dgv, List<EquipmentsModel> equModel, int num)
        {
            //设备对象，项目对象，更新标志位
            EquipmentsModel model = null;
            ProjectsModel projects = null;
            int index = 0;
            //这里，可以通过，之前创建用来收集项目的三个设备类型的List集合,通过设备类型ID来获取整个设备类型
            for (int i = 0; i < equModel.Count; i++)
            {
                if (num == equModel[i].Equipmentid)
                {
                    model = equModel[i];
                    index = i;
                    break;
                }
            }

            //这是通过设备ID来查询设备类型
            //EquipmentsModel equ = equBLL.QueryEquipMent(num);
            projects = proList[this.dgvProjects.CurrentRow.Index];
            //设备类型窗体
            FrmEquipMent frm = new FrmEquipMent(projects, model);
            DialogResult result = frm.ShowDialog();

            //返回结果,更新显示
            if (result == DialogResult.OK)
            {
                //DataSource已经绑定了List集合，如果从中删除，之后将修改的添加进去，就会报错
                dgv.DataSource = null;//一定需要先将其清空，放到后面会出错
                //把之前的对象删除掉，找到修改之后的对象
                equModel.Remove(model);
                EquipmentsModel equ = (EquipmentsModel)frm.Tag;
                equ.SN = model.SN;
                equModel.Insert(index, equ);
                dgv.DataSource = equModel;
            }
        }

        #endregion

        #region 删除设备类型

        /// <summary>
        /// 删除以太网设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_delete_IPEquipment_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_IPAddRess.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["equipmentid"].Value.ToString());
            DeleteEquipMent(this.dgv_EquipMent_IPAddRess, this.equIPAddRess, num);
        }
        /// <summary>
        /// 删除串口设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_delete_SerialEquipment_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMnetProt_SerialNo.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["equipmentid2"].Value.ToString());
            DeleteEquipMent(this.dgv_EquipMnetProt_SerialNo, this.equSerial, num);
        }
        /// <summary>
        /// 删除OPC设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_delete_OPCEquipment_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_OPC.Rows.Count <= 0) return;
            int num = Convert.ToInt32(this.dgv_EquipMent_OPC.CurrentRow.Cells["equipmentid3"].Value.ToString());
            DeleteEquipMent(this.dgv_EquipMent_OPC, this.equOPC, num);
        }

        /// <summary>
        /// 删除 设备DatGridView某个设备类型，通用方法
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="list"></param>
        /// <param name="equipmentid"></param>
        private void DeleteEquipMent(DataGridView dgv, List<EquipmentsModel> list, int equipmentid)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("没有数据可以删除", "删除提示", MessageBoxButtons.OK);
                return;
            }
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("没有选择要删除的对象", "删除提示", MessageBoxButtons.OK);
                return;
            }
            EquipmentsModel model = null;
            int index = 0;
            //这里，可以通过，之前创建用来收集项目的三个设备类型的List集合,通过设备类型ID来获取整个设备类型
            for (int i = 0; i < list.Count; i++)
            {
                if (equipmentid == list[i].Equipmentid)
                {
                    model = list[i];
                    index = i;
                    break;
                }
            }

            //确认是否删除
            DialogResult result = MessageBox.Show("确认是否删除此设备类型", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.equBLL.DeleteEquipMent(equipmentid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败，原因：" + ex.Message, "删除失败", MessageBoxButtons.OK);
                }
            }
            //把对象从数据集合中删除
            list.Remove(model);
            dgv.DataSource = null;
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SN = i + 1;
            }
            dgv.DataSource = list;
            this.CGroupList = null;
            this.VarList = null;
            this.dgv_CG.DataSource = null;
            this.dgv_Variable.DataSource = null;

        }

        #endregion

        #endregion

        #region 通信组 显示，添加，删除，修改

        #region 添加通信组

        /// <summary>
        /// 添加以太网设备通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tslm_Add_CGroup_Internet_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_IPAddRess.Rows.Count < 0) return;
            dgv_EquipMent_IPAddRess_Click(null, null);
            int num = Convert.ToInt32(this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["equipmentid"].Value.ToString());
            string equipmentName = this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["EquipmentName"].Value.ToString();
            ShowInsertCommunicationGroup(num, equipmentName, CGroupList);
        }
        /// <summary>
        /// 添加串口设备通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsml_Add_CGroup_Serial_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMnetProt_SerialNo.Rows.Count < 0) return;
            dgv_EquipMnetProt_SerialNo_Click(null, null);
            int num = Convert.ToInt32(this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["equipmentid2"].Value.ToString());
            string equipmentName = this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["EquipmentName2"].Value.ToString();
            ShowInsertCommunicationGroup(num, equipmentName, CGroupList);
        }
        /// <summary>
        /// 添加OPC设备通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsml_Add_CGroup_OPC_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMent_OPC.Rows.Count < 0) return;
            dgv_EquipMent_OPC_Click(null, null);
            int num = Convert.ToInt32(this.dgv_EquipMent_OPC.CurrentRow.Cells["equipmentid3"].Value.ToString());
            string equipmentName = this.dgv_EquipMent_OPC.CurrentRow.Cells["EquipmentName3"].Value.ToString();
            ShowInsertCommunicationGroup(num, equipmentName, CGroupList);
        }

        /// <summary>
        /// 添加通信组
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <param name="equipmentName"></param>
        /// <param name="list"></param>
        /// <param name="dgv"></param>
        public void ShowInsertCommunicationGroup(int equipmentid, string equipmentName, List<CommunicationsgroupsModel> list)
        {
            //右键实现添加通信组的时候
            //如果没有把当前设备通信组展示给用户，会让用户产生误解
            int projectid = Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["Projectid"].Value.ToString());
            FrmGroupAdd frm = new FrmGroupAdd(equipmentName, equipmentid, this.CGroupList, projectid);
            DialogResult resulut = frm.ShowDialog();
            if (frm.Tag != null)
            {
                list = (List<CommunicationsgroupsModel>)frm.Tag;
                this.dgv_CG.DataSource = null;
                this.dgv_CG.DataSource = list;
            }
        }

        #endregion

        #region 显示设备类型————对应通信组

        /// <summary>
        /// 单击显示以太网设备——对应通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMent_IPAddRess_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv_EquipMent_IPAddRess.Rows.Count <= 0) return;
                if (this.dgv_EquipMent_IPAddRess.CurrentRow == null) return;
                int index = Convert.ToInt32(this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["equipmentid"].Value.ToString());
                string equipmentname = this.dgv_EquipMent_IPAddRess.CurrentRow.Cells["EquipmentName"].Value.ToString();
                ShowCGroup(index, this.dgv_EquipMent_IPAddRess, equipmentname);
            }
            catch (IndexOutOfRangeException ex)
            {
                string s = ex.Message;
            }
        }

        /// <summary>
        /// 显示串口设备————对应的通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMnetProt_SerialNo_Click(object sender, EventArgs e)
        {
            if (this.dgv_EquipMnetProt_SerialNo.Rows.Count <= 0) return;
            if (this.dgv_EquipMnetProt_SerialNo.CurrentRow == null) return;
            int index = Convert.ToInt32(this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["equipmentid2"].Value.ToString());
            string equipmentname = this.dgv_EquipMnetProt_SerialNo.CurrentRow.Cells["EquipmentName2"].Value.ToString();
            ShowCGroup(index, this.dgv_EquipMnetProt_SerialNo, equipmentname);
        }

        /// <summary>
        /// 显示OPC设备————对应通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMent_OPC_Click(object sender, EventArgs e)
        {

            if (this.dgv_EquipMent_OPC.Rows.Count <= 0) return;
            if (this.dgv_EquipMent_OPC.CurrentRow == null) return;
            int index = Convert.ToInt32(this.dgv_EquipMent_OPC.CurrentRow.Cells["equipmentid3"].Value.ToString());
            string equipmentname = this.dgv_EquipMent_OPC.CurrentRow.Cells["EquipmentName3"].Value.ToString();
            ShowCGroup(index, this.dgv_EquipMent_OPC, equipmentname);
        }

        /// <summary>
        /// 显示通信组和通信组所含变量的通用方法
        /// </summary>
        /// <param name="index"></param>
        private void ShowCGroup(int index, DataGridView dgv, string equipmentname)
        {

            this.dgv_CG.DataSource = null;
            this.dgv_Variable.DataSource = null;
            this.CGroupList = CGBLL.SelectCommunticationGroup(index);
            if (this.CGroupList.Count != 0)
            {
                foreach (var item in this.CGroupList)
                {
                    item.EquipmentName = equipmentname;
                }
                //如果数据库中没有符合要求的集合
                //返回一个空集合，就会显示错误：索引-1处没有值
                this.dgv_CG.DataSource = this.CGroupList;
                this.dgv_CG.ClearSelection();

                this.dgv_CG.SelectionChanged += new System.EventHandler(this.dgv_CG_SelectionChanged);
                dgv_CG_SelectionChanged(null, null);
            }
            else
            {
                this.dgv_CG.SelectionChanged -= new System.EventHandler(this.dgv_CG_SelectionChanged);
            }
        }

        #endregion

        #region 修改通信组

        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_CommunicationGroup_Click(object sender, EventArgs e)
        {
            if (this.dgv_CG.Rows.Count < 0) return;
            if (this.dgv_CG.CurrentRow == null) return;
            int num = Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["sn4"].Value.ToString()) - 1;
            int index = 0;
            CommunicationsgroupsModel model = this.CGroupList[num];
            for (int i = 0; i < this.CGroupList.Count; i++)
            {
                if (num == this.CGroupList[i].SN)
                {
                    index = i;
                }
            }
            FrmGroupUpadate frm = new FrmGroupUpadate(model, Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["Projectid"].Value.ToString()));
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //第一种方式，找到对应集合的索引，然后删除
                //this.CGroupList.Remove(model);
                //this.dgv_CG.DataSource = null;
                //CommunicationsgroupsModel CG = (CommunicationsgroupsModel)frm.Tag;
                //this.CGroupList.Insert(index, CG);
                //this.dgv_CG.DataSource = this.CGroupList;

                //第二种方式直接刷新,此方法，是将集合中的某个元素，传到FrmCommunicationGroup窗体中，在其中修改此元素属性，本质上就是修改了List集合中对应的属性
                this.dgv_CG.Refresh();
            }
        }

        #endregion

        #region 删除通信组
        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_CommunicationGroup_Click(object sender, EventArgs e)
        {
            if (this.dgv_CG.Rows.Count == 0)
            {
                MessageBox.Show("没有数据可以删除", "删除提示", MessageBoxButtons.OK);
                return;
            }
            if (this.dgv_CG.CurrentRow == null)
            {
                MessageBox.Show("没有选择要删除的对象", "删除提示", MessageBoxButtons.OK);
                return;
            }

            int CGid = Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["cgid"].Value.ToString());

            //确认是否删除
            DialogResult result = MessageBox.Show("确认是否删除此设备类型", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    CGBLL.DeleteCommunicationGroup(CGid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败，原因：" + ex.Message, "删除失败", MessageBoxButtons.OK);
                }
            }
            //把对象从数据集合中删除
            this.CGroupList.Remove(this.CGroupList.First(c => c.Cgid==CGid));
            this.VarList = null;
            this.dgv_CG.DataSource = null;
            //更新显示
            if (this.CGroupList.Count > 0)
            {
                for (int i = 0; i < this.CGroupList.Count; i++)
                {
                    this.CGroupList[i].SN = i + 1;
                }
                this.dgv_CG.DataSource = this.CGroupList;
            }
        }
        #endregion

        #endregion

        #region 变量，显示，添加，删除，修改

        /// <summary>
        /// 添加变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddVariabl_Click(object sender, EventArgs e)
        {
            if (this.dgv_CG.Rows.Count <= 0) return;
            if (this.dgv_CG.CurrentRow == null) return;
            CommunicationsgroupsModel model = this.CGroupList.Find(c => c.Cgid == Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["cgid"].Value.ToString()));
            int projectid = Convert.ToInt32(this.dgvProjects.CurrentRow.Cells["Projectid"].Value.ToString());
            string cgName = this.dgv_CG.CurrentRow.Cells["Cgname"].Value.ToString();
            model.SN = this.VarList.Count + 1;
            FrmVariableAdd frm = new FrmVariableAdd(ReceiveInsertVariable, model, projectid);
            frm.ShowDialog();
        }

        /// <summary>
        /// 接受变量窗体传回值
        /// </summary>
        /// <param name="model"></param>
        private void ReceiveInsertVariable(VariablesModel model)
        {
            VarList=null;
            VarList=Variablebll.QueryVariable(model.Cgid);
            this.dgv_Variable.DataSource = null;
            this.dgv_Variable.DataSource = VarList;
        }

        /// <summary>
        /// 修改变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdateVariable_Click(object sender, EventArgs e)
        {
            if (this.dgv_Variable.Rows.Count <= 0) return;
            if (this.dgv_Variable.CurrentRow == null) return;
            int variableid = Convert.ToInt32(this.dgv_Variable.CurrentRow.Cells["variableid"].Value.ToString());
            string cgName = this.dgv_CG.CurrentRow.Cells["Cgname"].Value.ToString();
            VariablesModel model = this.VarList.Find(c => c.Variableid == variableid);
            FrmVariableAdd frm = new FrmVariableAdd(model, ReceiveUpdateVariable, cgName);
            frm.ShowDialog();
        }

        /// <summary>
        /// 刷新修改之后的变量组
        /// </summary>
        /// <param name="model"></param>
        public void ReceiveUpdateVariable(VariablesModel model)
        {
            //强制重绘控件
            this.dgv_Variable.Refresh();
            //也可以
            //int index = this.VarList.FindIndex(c => c.Variableid == model.Variableid);
            //this.VarList.RemoveAt(index);
            //this.VarList.Insert(index, model);
            //this.dgv_Variable.DataSource = null;
            //this.dgv_Variable.DataSource = this.VarList;
        }

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteVariable_Click(object sender, EventArgs e)
        {
            if (this.dgv_Variable.Rows.Count <= 0) return;
            if (this.dgv_Variable.CurrentRow == null) return;
            int variableId = Convert.ToInt32(this.dgv_Variable.CurrentRow.Cells["VariableId"].Value.ToString());
            try
            {
                if (this.Variablebll.DeleteVariable(variableId))
                {
                    VariablesModel model = this.VarList.Where(c => c.Variableid == variableId).First();
                    this.VarList.Remove(model);
                    this.dgv_Variable.DataSource = null;
                    for (int i = 0; i < this.VarList.Count; i++)
                    {
                        this.VarList[i].SN = i + 1;
                    }
                    this.dgv_Variable.DataSource = this.VarList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据删除错误原因：" + ex.Message, "变量配置", MessageBoxButtons.OK);
                return;
            }
        }

        /// <summary>
        /// 显示对应通信组的变量集合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CG_Click(object sender, EventArgs e)
        {
            this.dgv_Variable.DataSource = null;
            if (this.CGroupList.Count <= 0) return;
            if (this.dgv_CG.CurrentRow == null) return;
            //此处显示对应设备类型，第一个通信组的所有变量
            this.VarList = this.Variablebll.QueryVariable(Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["cgid"].Value.ToString()));
            //防止出现索引-1处没有值，需要判断
            if (this.VarList.Count > 0)
            {
                this.dgv_Variable.DataSource = this.VarList;
            }
        }
        #endregion

        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Variable_Paint(object sender, PaintEventArgs e)
        {
            DataGridViewStyle dt = new DataGridViewStyle();
            dt.DgvStyle1(this.dgv_Variable);
        }

        #region  双击触发修改
        /// <summary>
        /// 双击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Variable_DoubleClick(object sender, EventArgs e)
        {
            btn_UpdateVariable_Click(null, null);
        }

        /// <summary>
        /// 双击修改项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProjects_DoubleClick(object sender, EventArgs e)
        {
            btnUpdataProjectName_Click(null, null);
        }

        /// <summary>
        /// 双击修改选定的通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CG_DoubleClick(object sender, EventArgs e)
        {
            btn_Update_CommunicationGroup_Click(null, null);
        }

        /// <summary>
        /// 修改以太网设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMent_IPAddRess_DoubleClick(object sender, EventArgs e)
        {
            tsml_Update_Internet_Click(null, null);
        }
        /// <summary>
        /// 修改串口设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMnetProt_SerialNo_DoubleClick(object sender, EventArgs e)
        {
            tsml_Update_SerialPort_Click(null, null);
        }
        /// <summary>
        /// 修改OPC设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_EquipMent_OPC_DoubleClick(object sender, EventArgs e)
        {
            tsml_Update_OPC_Click(null, null);
        }
        #endregion

        /// <summary>
        /// 通信组选择改变时，变量对应改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CG_SelectionChanged(object sender, EventArgs e)
        {
            this.dgv_Variable.DataSource = null;
            if (this.dgv_CG.Rows.Count <= 0) return;
            if (this.dgv_CG.CurrentRow == null) return;
            //此处显示对应设备类型，第一个通信组的所有变量
            try
            {
                this.VarList = this.Variablebll.QueryVariable(Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["cgid"].Value));
                //防止出现索引-1处没有值，需要判断
                if (this.VarList.Count > 0)
                {
                    this.dgv_Variable.DataSource = this.VarList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK);
            }
        }


       
        /// <summary>
        /// 导入CSV文件数据内容导入List<VariableModel>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btn_ReadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "选择导入文件";
            dlg.Multiselect = false;
            dlg.Filter = "CSV文件|*.CSV";
            dlg.InitialDirectory = @"C:\Users";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                string path = dlg.FileName;
                List<VariablesModel> varList = Common.CsvHelper.CsvToList<VariablesModel>(path,true);

                //为了避免删除元素时，影响索引，采用倒叙的方法
                for (int i = varList.Count - 1; i >= 0; i--)
                {
                    varList[i].Cgid = Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["CGID"].Value);

                    if (this.VarList.Any(c => c.Variablename == varList[i].Variablename))
                    {
                        varList.RemoveAt(i);
                    }
                }
                if (Variablebll.InsertVariables(varList))
                {
                    this.VarList=null;
                    this.VarList = this.Variablebll.QueryVariable(Convert.ToInt32(this.dgv_CG.CurrentRow.Cells["CGID"].Value));
                    this.dgv_Variable.DataSource = null;
                    for (int i = 0; i <this.VarList.Count; i++)
                    {
                        this.VarList[i].SN = i + 1;
                    }
                    this.dgv_Variable.DataSource= this.VarList;
                }
            }
        }

        /// <summary>
        /// 导出变量为csv文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "保存文件";
            dlg.InitialDirectory = @"C:\Users";
            dlg.Filter = "CSV文件|*.csv|Excel文件|*.xlsx";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                string path = dlg.FileName;
                Common.CsvHelper.ListToCsv((List<VariablesModel>)this.dgv_Variable.DataSource,path,true);
                Process.Start(path);
                //ExcelHelper.DataGridViewToExcel(path, this.dgv_Variable,true);
            }
        }

        /// <summary>
        /// 导出配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDeviceFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter="json文件|*.json|所有文件|*.*";
            saveFileDialog.Title="配置文件";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.RestoreDirectory=true;

            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                string projectName = this.dgvProjects.CurrentRow.Cells["ProjectName"].Value.ToString();
                bool result = new ConfigManage().ExportProjects(path, projectName);
                if (result)
                {
                    MessageBox.Show("配置文件", "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.rtb.Text=null;
                    this.rtb.Text=File.ReadAllText(path);

                }
                else
                {
                    MessageBox.Show("配置文件", "导出失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

    }
}
