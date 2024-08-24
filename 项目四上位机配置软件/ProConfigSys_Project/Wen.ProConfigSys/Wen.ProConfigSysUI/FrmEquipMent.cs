using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.BLL;
using Wen.Common;
using Wen.Models;

namespace Wen.ProConfigSysUI
{
    public partial class FrmEquipMent : Form
    {
        /// <summary>
        /// 设备类型的业务逻辑对象
        /// </summary>
        private EquipMentBLL equipMentBll = new EquipMentBLL();

        /// <summary>
        /// 设备类型泛型集合
        /// </summary>
        public List<EquipmenttypeModel> eTypeList = new List<EquipmenttypeModel>();

        /// <summary>
        /// 设备类型---通信协议
        /// </summary>
        public Dictionary<string, List<ProtocoltypeModel>> proList = new Dictionary<string, List<ProtocoltypeModel>>();

        /// <summary>
        /// 项目对象
        /// </summary>
        private ProjectsModel projects = new ProjectsModel();

        /// <summary>
        /// 设备对象，用来存储设备ID
        /// </summary>
        private EquipmentsModel equ=new EquipmentsModel();

        /// <summary>
        /// 串口连接的校验位
        /// </summary>
        public string[] parityItems = new string[] { "None", "Odd", "Even","Mark","Space" };

        /// <summary>
        /// 窗体标志位，判断是添加还是修改
        /// </summary>
        public bool IsModify;

        /// <summary>
        /// 窗体初始化构造函数
        /// </summary>
        public FrmEquipMent()
        {
            InitializeComponent();

            #region 初始化
            this.lbl_Comment.Visible=false;
            //查询设备类型
            GetEType();

            ///初始化三个GroupBox
            InitializationGroupBox();

            //初始化添加数据校验位字段
            this.cmbParityBit.Items.AddRange(parityItems);

            //默认为添加设备类型
            this.IsModify = false;
            #endregion
        }

        /// <summary>
        /// 传递修改EquipMent对象的构造函数
        /// </summary>
        /// <param name="model"></param>
        public FrmEquipMent(ProjectsModel project,EquipmentsModel model) : this(project)
        {
            //是否修改标志位
            this.equ = model;
            this.IsModify = true;
            this.txtEquipMentName.Text = model.EquipmentName;
            this.cmbEType.SelectedValue = model.Etypeid;
            this.cmbProtocolType.SelectedValue = model.Ptypeid;
            switch (model.Etypeid)
            {
                case 10:
                    this.txtIPAddRess.Text = model.Ipaddress;
                    this.txtPortNo.Text = model.Portno;
                    break;
                case 11:
                    this.cmbSerialPort.Text = model.Serialno;
                    this.cmbBaudRate.Text = model.Baudrate.ToString();
                    this.cmbDataBit.Text=model.Databit.ToString();
                    this.cmbParityBit.Text=model.Paritybit.ToString();
                    this.cmbStopBit.Text=model.Stopbit.ToString();

                    break;
                case 12:
                    this.txtOPCnodeName.Text = model.Opcnodename;
                    this.txtOPCserverName.Text = model.Opcservername;
                    break;
                default:
                    break;
            }
            this.txtComments.Text = model.Comments; 
            this.chkIsEnable.Checked=model.Isenable==1?true:false;
            this.btnAddEquipeMents.Text = "修改设备类型";

            //如果允许被修改设备类型，会造成程序太麻烦
            this.cmbEType.Enabled = false;
        }

        /// <summary>
        /// 传递Project项目对象构造函数
        /// </summary>
        /// <param name="model"></param>
        public FrmEquipMent(ProjectsModel model) : this()
        {
            this.projects = model;
            this.lblProject.Text = model.Projectname;
        }

        #region 设备类型联动
        /// <summary>
        /// 查询设备类型，并且查询每个对应类型的通信协议
        /// </summary>
        public void GetEType()
        {
            //查询设备类型
            this.eTypeList = this.equipMentBll.QueryEType();
            this.cmbEType.DataSource = eTypeList;
            this.cmbEType.ValueMember = "Etypeid";
            this.cmbEType.DisplayMember = "EtypeName";
            //默认没有选择设备类型
            this.cmbEType.SelectedIndex = -1;

            //查询协议类型
            foreach (EquipmenttypeModel eType in eTypeList)
            {
                this.proList.Add(eType.Etypename, this.equipMentBll.QueryProtocolType(eType.Etypeid));
            }
            //如果对应的事件触发，需要满足之前绑定的数据要查询完毕之后才可以触发
            this.cmbEType.SelectedIndexChanged += new System.EventHandler(this.cmbEType_SelectedIndexChanged);
        }

        #region 自我方法一，通过switch 来判断选择的那种设备类型，查询相对应的通信协议
        public void SelectIndexChanage()
        {
            if (this.eTypeList.Count > 0)
            {
                switch (this.cmbEType.Text)
                {
                    case "以太网":
                        this.cmbProtocolType.DataSource = this.proList["以太网"];
                        this.cmbProtocolType.ValueMember = "ptypeid";
                        this.cmbProtocolType.DisplayMember = "ptypename";
                        this.cmbProtocolType.SelectedIndex = -1;
                        break;
                    case "串口":
                        this.cmbProtocolType.DataSource = this.proList["串口"];
                        this.cmbProtocolType.ValueMember = "Ptypeid";
                        this.cmbProtocolType.DisplayMember = "ptypename";
                        this.cmbProtocolType.SelectedIndex = -1;
                        break;
                    case "OPC":
                        this.cmbProtocolType.DataSource = this.proList["OPC"];
                        this.cmbProtocolType.ValueMember = "Ptypeid";
                        this.cmbProtocolType.DisplayMember = "ptypename";
                        this.cmbProtocolType.SelectedIndex = -1;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        /// <summary>
        /// 初始化GroupBox的Enable和BackColor属性
        /// </summary>
        public void InitializationGroupBox()
        {
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox1.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        //方法二，但是这种索引改变触发的事件需要，在控件本身的数据源，收集其之后触发
        /// <summary>
        /// 通过选定的设备类型，显示对应的通信协议容器控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbProtocolType.DataSource = this.proList[this.cmbEType.Text];
            this.cmbProtocolType.ValueMember = "Ptypeid";
            this.cmbProtocolType.DisplayMember = "ptypename";
            this.cmbProtocolType.SelectedIndex = -1;
            //初始化GroupBox的Enable和BackColor属性
            InitializationGroupBox();
            //判断选择设备类型选择方式
            switch (this.cmbEType.Text)
            {
                case "以太网":
                    this.groupBox1.Enabled = true;
                    this.groupBox1.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    break;
                case "串口":
                    this.groupBox2.Enabled = true;
                    this.groupBox2.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    break;
                case "OPC":
                    this.groupBox3.Enabled = true;
                    this.groupBox3.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    break;
                default:
                    break;
            }
        }

        #endregion

        /// <summary>
        /// 添加新设备/修改设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEquipeMents_Click(object sender, EventArgs e)
        {
            EquipmentsModel model = new EquipmentsModel();

            //验证数据
            if (!(this.txtEquipMentName.Text.ToString().Trim().Length > 0))
            {
                MessageBox.Show("设备名为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtEquipMentName.Focus();
                return;
            }
            //这里将ComboBox的DropDownStyle：设置控件的外观和功能，将其改为DorpDownList保证只能选择，不能输入文字
            if (this.cmbEType.SelectedIndex < 0)
            {
                MessageBox.Show("设备类型为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cmbEType.Focus();
                return;
            }
            if (this.cmbProtocolType.SelectedIndex < 0)
            {
                MessageBox.Show("通信协议为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cmbProtocolType.Focus();
                return;
            }
            //添加
            if (this.IsModify == false)
            {
                switch (this.cmbEType.Text)
                {
                    case "以太网":
                        if (this.txtIPAddRess.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("IP地址为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtIPAddRess.Focus();
                            return;
                        }
                        if (DataValidate.IsIpAddress(this.txtIPAddRess.Text.ToString().Trim()))
                        {
                            MessageBox.Show("Ip输入的格式不对，请重新输入", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtIPAddRess.Text = null;
                            this.txtIPAddRess.Focus();
                            return;
                        }
                        if (this.txtPortNo.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("端口号为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtPortNo.Focus();
                            return;
                        }
                        if (!DataValidate.IsInteger(this.txtPortNo.Text))
                        {
                            MessageBox.Show("端口号要是正整数", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtPortNo.Focus();
                            return;
                        }
                        model.Ipaddress = this.txtIPAddRess.Text;
                        model.Portno = this.txtPortNo.Text;
                        break;
                    case "串口":
                        if (this.cmbSerialPort.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("串口号为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbSerialPort.Focus();
                            return;
                        }
                        if (this.cmbBaudRate.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("波特率为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbBaudRate.Focus();
                            return;
                        }
                        if (this.cmbDataBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("数据位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbDataBit.Focus();
                            return;
                        }
                        if (this.cmbParityBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("校验位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbParityBit.Focus();
                            return;
                        }
                        if (this.cmbStopBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("停止位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbStopBit.Focus();
                            return;
                        }
                        model.Serialno = this.cmbSerialPort.Text;
                        model.Baudrate = Convert.ToInt32(this.cmbBaudRate.Text);
                        model.Databit = Convert.ToInt32(this.cmbDataBit.Text);
                        model.Paritybit = this.cmbParityBit.Text;
                        model.Stopbit = Convert.ToInt32(this.cmbStopBit.Text);
                        model.ProjectName = this.lblProject.Text;
                        break;
                    case "OPC":
                        if (this.txtOPCnodeName.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("节点名称", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtOPCnodeName.Focus();
                            return;
                        }
                        if (this.txtOPCserverName.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("服务器名", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtOPCserverName.Focus();
                            return;
                        }
                        model.Opcnodename = this.txtOPCnodeName.Text;
                        model.Opcservername = this.txtOPCserverName.Text;
                        break;
                    default:
                        break;
                }
                if (equipMentBll.IsRepareforInsert(this.txtEquipMentName.Text, this.projects.Projectid))
                {
                    MessageBox.Show("设备名称在这个项目下已存在", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtEquipMentName.Focus();
                    return;
                }
            }

            //修改
            else
            {
                //这里要验证设备类型是否重复，原本对应的设备类型的内容是否为空，而且是否修改
                switch (this.cmbEType.Text)
                {
                    case "以太网":
                        if (this.txtIPAddRess.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("IP地址为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtIPAddRess.Focus();
                            return;
                        }
                        if (DataValidate.IsIpAddress(this.txtIPAddRess.Text.ToString().Trim()))
                        {
                            MessageBox.Show("Ip输入的格式不对，请重新输入", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtIPAddRess.Text = null;
                            this.txtIPAddRess.Focus();
                            return;
                        }
                        if (this.txtPortNo.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("端口号为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtPortNo.Focus();
                            return;
                        }
                        if (!DataValidate.IsInteger(this.txtPortNo.Text))
                        {
                            MessageBox.Show("端口号要是正整数", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtPortNo.Focus();
                            return;
                        }
                        model.Ipaddress = this.txtIPAddRess.Text;
                        model.Portno = this.txtPortNo.Text;
                        break;
                    case "串口":
                        if (this.cmbSerialPort.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("串口号为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbSerialPort.Focus();
                            return;
                        }
                        if (this.cmbBaudRate.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("波特率为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbBaudRate.Focus();
                            return;
                        }
                        if (this.cmbDataBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("数据位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbDataBit.Focus();
                            return;
                        }
                        if (this.cmbParityBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("校验位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbParityBit.Focus();
                            return;
                        }
                        if (this.cmbStopBit.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("停止位为空", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.cmbStopBit.Focus();
                            return;
                        }
                        model.Serialno = this.cmbSerialPort.Text;
                        model.Baudrate = Convert.ToInt32(this.cmbBaudRate.Text);
                        model.Databit = Convert.ToInt32(this.cmbDataBit.Text);
                        model.Paritybit = this.cmbParityBit.Text;
                        model.Stopbit = Convert.ToInt32(this.cmbStopBit.Text);
                        model.ProjectName = this.lblProject.Text;
                        break;
                    case "OPC":
                        if (this.txtOPCnodeName.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("节点名称", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtOPCnodeName.Focus();
                            return;
                        }
                        if (this.txtOPCserverName.Text.ToString().Trim().Length == 0)
                        {
                            MessageBox.Show("服务器名", "设备管理", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtOPCserverName.Focus();
                            return;
                        }
                        model.Opcnodename = this.txtOPCnodeName.Text;
                        model.Opcservername = this.txtOPCserverName.Text;
                        break;
                    default:
                        break;
                }
            }

            //封装对象
            model.EquipmentName = this.txtEquipMentName.Text;
            model.Etypeid = Convert.ToInt32(this.cmbEType.SelectedValue);
            model.EtypeName = this.cmbEType.Text;
            model.PtypeName = this.cmbProtocolType.Text;
            model.Ptypeid = Convert.ToInt32(this.cmbProtocolType.SelectedValue);
            model.Comments = this.txtComments.Text;
            model.Isenable = this.chkIsEnable.Checked == true ? 1 : 0;
            model.Projectid=this.projects.Projectid;
            //添加对象
            if (this.IsModify == false)
            {
                if (equipMentBll.IsRepareforInsert(model.EquipmentName, model.Projectid))
                {
                    MessageBox.Show("设备名称不能重复", "提示信息", MessageBoxButtons.OK);
                    this.txtEquipMentName.Clear();
                    this.txtEquipMentName.Focus();
                    return;
                }
                InsertModel(model);
            }
            //修改对象
            else
            {
                model.Equipmentid = this.equ.Equipmentid;
                if (equipMentBll.IsRepareForUpdate(model.EquipmentName,model.Projectid,model.Equipmentid))
                {
                    MessageBox.Show("修改的设备名，已存在","提示信息",MessageBoxButtons.OK);
                    this.txtEquipMentName.Clear();
                    this.txtEquipMentName.Focus();
                    return;
                }
                UpdateModel(model);
            }
        }

        /// <summary>
        /// 新增对象
        /// </summary>
        /// <param name="model">Equipment对象</param>
        public void InsertModel(EquipmentsModel model)
        {
            try
            {
                //保存数据
                int num = equipMentBll.InsertEquipMent(model);
                if (num > 0)
                {
                    model.Equipmentid = num;
                }

                //返回数据
                this.Tag = model;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库对象"+ex.Message,"错误提示");
                return;
            }
        }

        /// <summary>
        /// 修改对象
        /// </summary>
        /// <param name="model"></param>
        public void UpdateModel(EquipmentsModel model)
        {
            try 
            {
                if (equipMentBll.UpdateEquipMent(model))
                {
                    this.Tag = model;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库对象" + ex.Message, "错误提示");
                return;
            }
        }

        private void cmbProtocolType_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cmbProtocolType.Text)
            {
                case "西门子S7":
                    this.lbl_Comment.Visible=true;
                    this.lbl_Comment.Text="S7200,LogoOBAB8,S7200Smart,S7300,S7400,S71200,S71500,只可以选择其中一个，写为备注";
                    break;
                case "三菱AIE":
                case "三菱MC":
                    this.lbl_Comment.Visible=true;
                    this.lbl_Comment.Text="FX3U,FX5U,Q,只能选择其中一个，其他的删除啊";
                    break;
                case "欧姆龙HostLink":
                    this.lbl_Comment.Visible=true;
                    this.lbl_Comment.Text="请输入单元号UNIT，PLC单元号SA2，响应时间ResponseWaitTime,用英文标点“.”隔开";
                    break;
                case "ModbusRTU":
                case "ModbusASCII":
                case "ModbusTCP":
                case "ModbusRTUOverTCP":
                    this.lbl_Comment.Visible=true;
                    this.lbl_Comment.Text="请输入true或者false,用来判断是长短地址类型,true是长地址类型，false是短地址类型";
                    break;
                default:
                    this.lbl_Comment.Visible=false;
                    break;
            }
        }
    }
}
