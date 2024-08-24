namespace Wen.ProConfigSysUI
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_EquipMent_IPAddRess = new System.Windows.Forms.DataGridView();
            this.SN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipMentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ptypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsml_Update_Internet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete_IPEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslm_Add_CGroup_Internet = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ReadCSV = new System.Windows.Forms.Button();
            this.btn_SaveCSV = new System.Windows.Forms.Button();
            this.btn_DeleteVariable = new System.Windows.Forms.Button();
            this.btn_UpdateVariable = new System.Windows.Forms.Button();
            this.btn_AddVariabl = new System.Windows.Forms.Button();
            this.dgv_Variable = new System.Windows.Forms.DataGridView();
            this.SN5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddRess1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMaxAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ALarmMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmMaxNode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMinAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AlarmMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmMinNode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offsetorlength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isfile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variableid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_EquipMent_OPC = new System.Windows.Forms.DataGridView();
            this.SN3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtypeName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtypeName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPCNodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPCServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnable3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipmentid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etypid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ptypeid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsml_Update_OPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete_OPCEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsml_Add_CGroup_OPC = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_EquipMnetProt_SerialNo = new System.Windows.Forms.DataGridView();
            this.SN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipMentName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtypeName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtypeName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriableNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baudrate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParityBit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopBit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnable2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etypeid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ptypeid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsml_Update_SerialPort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_delete_SerialEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsml_Add_CGroup_Serial = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEquipMents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_CG = new System.Windows.Forms.DataGridView();
            this.SN4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddRess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete_CommunicationGroup = new System.Windows.Forms.Button();
            this.btn_Update_CommunicationGroup = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnUpdataProjectName = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.tal_faction = new System.Windows.Forms.TabPage();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_SaveDeviceFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlbleUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMent_IPAddRess)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Variable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMent_OPC)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMnetProt_SerialNo)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CG)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tal_faction.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tal_faction);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1799, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dgv_EquipMent_IPAddRess);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dgv_Variable);
            this.tabPage1.Controls.Add(this.dgv_EquipMent_OPC);
            this.tabPage1.Controls.Add(this.dgv_EquipMnetProt_SerialNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAddEquipMents);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_CG);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvProjects);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1791, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "项目配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_EquipMent_IPAddRess
            // 
            this.dgv_EquipMent_IPAddRess.AllowUserToAddRows = false;
            this.dgv_EquipMent_IPAddRess.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EquipMent_IPAddRess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_EquipMent_IPAddRess.ColumnHeadersHeight = 30;
            this.dgv_EquipMent_IPAddRess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN1,
            this.EquipmentName,
            this.dataGridViewTextBoxColumn5,
            this.PtypeName,
            this.dataGridViewTextBoxColumn7,
            this.Column5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.EquipMentid,
            this.Etypeid,
            this.Ptypeid});
            this.dgv_EquipMent_IPAddRess.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_EquipMent_IPAddRess.Location = new System.Drawing.Point(4, 419);
            this.dgv_EquipMent_IPAddRess.Name = "dgv_EquipMent_IPAddRess";
            this.dgv_EquipMent_IPAddRess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_EquipMent_IPAddRess.RowHeadersVisible = false;
            this.dgv_EquipMent_IPAddRess.RowTemplate.Height = 23;
            this.dgv_EquipMent_IPAddRess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_EquipMent_IPAddRess.Size = new System.Drawing.Size(900, 89);
            this.dgv_EquipMent_IPAddRess.TabIndex = 7;
            this.dgv_EquipMent_IPAddRess.Click += new System.EventHandler(this.dgv_EquipMent_IPAddRess_Click);
            this.dgv_EquipMent_IPAddRess.DoubleClick += new System.EventHandler(this.dgv_EquipMent_IPAddRess_DoubleClick);
            // 
            // SN1
            // 
            this.SN1.DataPropertyName = "sn";
            this.SN1.HeaderText = "序号";
            this.SN1.Name = "SN1";
            this.SN1.Width = 50;
            // 
            // EquipmentName
            // 
            this.EquipmentName.DataPropertyName = "EquipmentName";
            this.EquipmentName.HeaderText = "设备名称";
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EtypeName";
            this.dataGridViewTextBoxColumn5.HeaderText = "设备类型";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PtypeName
            // 
            this.PtypeName.DataPropertyName = "PtypeName";
            this.PtypeName.HeaderText = "协议类型";
            this.PtypeName.Name = "PtypeName";
            this.PtypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IPaddress";
            this.dataGridViewTextBoxColumn7.HeaderText = "IP地址";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "portno";
            this.Column5.HeaderText = "端口号";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isenable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "启用";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "comments";
            this.dataGridViewCheckBoxColumn2.HeaderText = "备注";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EquipMentid
            // 
            this.EquipMentid.DataPropertyName = "EquipMentID";
            this.EquipMentid.HeaderText = "EquipMentid";
            this.EquipMentid.Name = "EquipMentid";
            this.EquipMentid.Visible = false;
            // 
            // Etypeid
            // 
            this.Etypeid.DataPropertyName = "Etypeid";
            this.Etypeid.HeaderText = "Etypeid";
            this.Etypeid.Name = "Etypeid";
            this.Etypeid.Visible = false;
            // 
            // Ptypeid
            // 
            this.Ptypeid.DataPropertyName = "ptypeid";
            this.Ptypeid.HeaderText = "Ptypeid";
            this.Ptypeid.Name = "Ptypeid";
            this.Ptypeid.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsml_Update_Internet,
            this.tsmi_delete_IPEquipment,
            this.toolStripSeparator1,
            this.tslm_Add_CGroup_Internet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 100);
            // 
            // tsml_Update_Internet
            // 
            this.tsml_Update_Internet.Name = "tsml_Update_Internet";
            this.tsml_Update_Internet.Size = new System.Drawing.Size(217, 30);
            this.tsml_Update_Internet.Text = "修改以太网设备";
            this.tsml_Update_Internet.Click += new System.EventHandler(this.tsml_Update_Internet_Click);
            // 
            // tsmi_delete_IPEquipment
            // 
            this.tsmi_delete_IPEquipment.Name = "tsmi_delete_IPEquipment";
            this.tsmi_delete_IPEquipment.Size = new System.Drawing.Size(217, 30);
            this.tsmi_delete_IPEquipment.Text = "删除以太网设备";
            this.tsmi_delete_IPEquipment.Click += new System.EventHandler(this.tsmi_delete_IPEquipment_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // tslm_Add_CGroup_Internet
            // 
            this.tslm_Add_CGroup_Internet.Name = "tslm_Add_CGroup_Internet";
            this.tslm_Add_CGroup_Internet.Size = new System.Drawing.Size(217, 30);
            this.tslm_Add_CGroup_Internet.Text = "新增通信组配置";
            this.tslm_Add_CGroup_Internet.Click += new System.EventHandler(this.tslm_Add_CGroup_Internet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ReadCSV);
            this.groupBox3.Controls.Add(this.btn_SaveCSV);
            this.groupBox3.Controls.Add(this.btn_DeleteVariable);
            this.groupBox3.Controls.Add(this.btn_UpdateVariable);
            this.groupBox3.Controls.Add(this.btn_AddVariabl);
            this.groupBox3.Location = new System.Drawing.Point(1025, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "变量信息";
            // 
            // btn_ReadCSV
            // 
            this.btn_ReadCSV.FlatAppearance.BorderSize = 0;
            this.btn_ReadCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReadCSV.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_ReadCSV.Location = new System.Drawing.Point(601, 28);
            this.btn_ReadCSV.Name = "btn_ReadCSV";
            this.btn_ReadCSV.Size = new System.Drawing.Size(130, 27);
            this.btn_ReadCSV.TabIndex = 4;
            this.btn_ReadCSV.Text = "导入CSV";
            this.btn_ReadCSV.UseVisualStyleBackColor = true;
            this.btn_ReadCSV.Click += new System.EventHandler(this.btn_ReadCSV_Click);
            // 
            // btn_SaveCSV
            // 
            this.btn_SaveCSV.FlatAppearance.BorderSize = 0;
            this.btn_SaveCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SaveCSV.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_SaveCSV.Location = new System.Drawing.Point(455, 28);
            this.btn_SaveCSV.Name = "btn_SaveCSV";
            this.btn_SaveCSV.Size = new System.Drawing.Size(130, 27);
            this.btn_SaveCSV.TabIndex = 3;
            this.btn_SaveCSV.Text = "导出CSV";
            this.btn_SaveCSV.UseVisualStyleBackColor = true;
            this.btn_SaveCSV.Click += new System.EventHandler(this.btn_SaveCSV_Click);
            // 
            // btn_DeleteVariable
            // 
            this.btn_DeleteVariable.FlatAppearance.BorderSize = 0;
            this.btn_DeleteVariable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteVariable.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteVariable.Location = new System.Drawing.Point(309, 28);
            this.btn_DeleteVariable.Name = "btn_DeleteVariable";
            this.btn_DeleteVariable.Size = new System.Drawing.Size(130, 27);
            this.btn_DeleteVariable.TabIndex = 2;
            this.btn_DeleteVariable.Text = "删除变量";
            this.btn_DeleteVariable.UseVisualStyleBackColor = true;
            this.btn_DeleteVariable.Click += new System.EventHandler(this.btn_DeleteVariable_Click);
            // 
            // btn_UpdateVariable
            // 
            this.btn_UpdateVariable.FlatAppearance.BorderSize = 0;
            this.btn_UpdateVariable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UpdateVariable.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateVariable.Location = new System.Drawing.Point(163, 28);
            this.btn_UpdateVariable.Name = "btn_UpdateVariable";
            this.btn_UpdateVariable.Size = new System.Drawing.Size(130, 27);
            this.btn_UpdateVariable.TabIndex = 1;
            this.btn_UpdateVariable.Text = "修改变量";
            this.btn_UpdateVariable.UseVisualStyleBackColor = true;
            this.btn_UpdateVariable.Click += new System.EventHandler(this.btn_UpdateVariable_Click);
            // 
            // btn_AddVariabl
            // 
            this.btn_AddVariabl.FlatAppearance.BorderSize = 0;
            this.btn_AddVariabl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddVariabl.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_AddVariabl.Location = new System.Drawing.Point(17, 28);
            this.btn_AddVariabl.Name = "btn_AddVariabl";
            this.btn_AddVariabl.Size = new System.Drawing.Size(130, 27);
            this.btn_AddVariabl.TabIndex = 0;
            this.btn_AddVariabl.Text = "增加变量";
            this.btn_AddVariabl.UseVisualStyleBackColor = true;
            this.btn_AddVariabl.Click += new System.EventHandler(this.btn_AddVariabl_Click);
            // 
            // dgv_Variable
            // 
            this.dgv_Variable.AllowUserToAddRows = false;
            this.dgv_Variable.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Variable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Variable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Variable.ColumnHeadersHeight = 30;
            this.dgv_Variable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN5,
            this.VariableName,
            this.StartAddRess1,
            this.DataType,
            this.IsMaxAlarm,
            this.ALarmMax,
            this.AlarmMaxNode,
            this.IsMinAlarm,
            this.AlarmMin,
            this.AlarmMinNode,
            this.Scale,
            this.Offsetorlength,
            this.Isfile,
            this.Comments5,
            this.Variableid});
            this.dgv_Variable.Location = new System.Drawing.Point(938, 67);
            this.dgv_Variable.Name = "dgv_Variable";
            this.dgv_Variable.RowHeadersVisible = false;
            this.dgv_Variable.RowTemplate.Height = 23;
            this.dgv_Variable.Size = new System.Drawing.Size(832, 595);
            this.dgv_Variable.TabIndex = 10;
            this.dgv_Variable.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Variable_Paint);
            this.dgv_Variable.DoubleClick += new System.EventHandler(this.dgv_Variable_DoubleClick);
            // 
            // SN5
            // 
            this.SN5.DataPropertyName = "sn";
            this.SN5.Frozen = true;
            this.SN5.HeaderText = "序号";
            this.SN5.Name = "SN5";
            this.SN5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SN5.Width = 50;
            // 
            // VariableName
            // 
            this.VariableName.DataPropertyName = "VariableName";
            this.VariableName.Frozen = true;
            this.VariableName.HeaderText = "变量名";
            this.VariableName.Name = "VariableName";
            this.VariableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VariableName.Width = 70;
            // 
            // StartAddRess1
            // 
            this.StartAddRess1.DataPropertyName = "StartAddress";
            this.StartAddRess1.Frozen = true;
            this.StartAddRess1.HeaderText = "起始地址";
            this.StartAddRess1.Name = "StartAddRess1";
            this.StartAddRess1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartAddRess1.Width = 80;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.Frozen = true;
            this.DataType.HeaderText = "数据类型";
            this.DataType.Name = "DataType";
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataType.Width = 80;
            // 
            // IsMaxAlarm
            // 
            this.IsMaxAlarm.DataPropertyName = "IsMaxAlarm";
            this.IsMaxAlarm.HeaderText = "上限值报警";
            this.IsMaxAlarm.Name = "IsMaxAlarm";
            // 
            // ALarmMax
            // 
            this.ALarmMax.DataPropertyName = "ALarmMax";
            this.ALarmMax.HeaderText = "上限值";
            this.ALarmMax.Name = "ALarmMax";
            this.ALarmMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ALarmMax.Width = 60;
            // 
            // AlarmMaxNode
            // 
            this.AlarmMaxNode.DataPropertyName = "AlarmMaxNode";
            this.AlarmMaxNode.HeaderText = "上限报警说明";
            this.AlarmMaxNode.Name = "AlarmMaxNode";
            // 
            // IsMinAlarm
            // 
            this.IsMinAlarm.DataPropertyName = "ISAlarmMin";
            this.IsMinAlarm.HeaderText = "下限值报警";
            this.IsMinAlarm.Name = "IsMinAlarm";
            // 
            // AlarmMin
            // 
            this.AlarmMin.DataPropertyName = "AlarmMin";
            this.AlarmMin.HeaderText = "下限值";
            this.AlarmMin.Name = "AlarmMin";
            this.AlarmMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlarmMin.Width = 70;
            // 
            // AlarmMinNode
            // 
            this.AlarmMinNode.DataPropertyName = "AlarmMinNode";
            this.AlarmMinNode.HeaderText = "下限报警说明";
            this.AlarmMinNode.Name = "AlarmMinNode";
            // 
            // Scale
            // 
            this.Scale.DataPropertyName = "Scale";
            this.Scale.HeaderText = "线性系数";
            this.Scale.Name = "Scale";
            this.Scale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Scale.Width = 80;
            // 
            // Offsetorlength
            // 
            this.Offsetorlength.DataPropertyName = "Offsetorlength";
            this.Offsetorlength.HeaderText = "线性偏移量";
            this.Offsetorlength.Name = "Offsetorlength";
            // 
            // Isfile
            // 
            this.Isfile.DataPropertyName = "IsFile";
            this.Isfile.HeaderText = "归档";
            this.Isfile.Name = "Isfile";
            this.Isfile.Width = 50;
            // 
            // Comments5
            // 
            this.Comments5.DataPropertyName = "Comments";
            this.Comments5.HeaderText = "备注";
            this.Comments5.Name = "Comments5";
            this.Comments5.Width = 150;
            // 
            // Variableid
            // 
            this.Variableid.DataPropertyName = "variableid";
            this.Variableid.HeaderText = "变量ID";
            this.Variableid.Name = "Variableid";
            this.Variableid.Visible = false;
            // 
            // dgv_EquipMent_OPC
            // 
            this.dgv_EquipMent_OPC.AllowUserToAddRows = false;
            this.dgv_EquipMent_OPC.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EquipMent_OPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_EquipMent_OPC.ColumnHeadersHeight = 30;
            this.dgv_EquipMent_OPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN3,
            this.EquipmentName3,
            this.EtypeName3,
            this.PtypeName3,
            this.OPCNodeName,
            this.OPCServerName,
            this.IsEnable3,
            this.Comments3,
            this.Equipmentid3,
            this.Etypid3,
            this.Ptypeid3});
            this.dgv_EquipMent_OPC.ContextMenuStrip = this.contextMenuStrip3;
            this.dgv_EquipMent_OPC.Location = new System.Drawing.Point(4, 609);
            this.dgv_EquipMent_OPC.Name = "dgv_EquipMent_OPC";
            this.dgv_EquipMent_OPC.RowHeadersVisible = false;
            this.dgv_EquipMent_OPC.RowTemplate.Height = 23;
            this.dgv_EquipMent_OPC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_EquipMent_OPC.Size = new System.Drawing.Size(900, 81);
            this.dgv_EquipMent_OPC.TabIndex = 9;
            this.dgv_EquipMent_OPC.Click += new System.EventHandler(this.dgv_EquipMent_OPC_Click);
            this.dgv_EquipMent_OPC.DoubleClick += new System.EventHandler(this.dgv_EquipMent_OPC_DoubleClick);
            // 
            // SN3
            // 
            this.SN3.DataPropertyName = "SN";
            this.SN3.HeaderText = "序号";
            this.SN3.Name = "SN3";
            this.SN3.Width = 50;
            // 
            // EquipmentName3
            // 
            this.EquipmentName3.DataPropertyName = "equipmentname";
            this.EquipmentName3.HeaderText = "设备名称";
            this.EquipmentName3.Name = "EquipmentName3";
            this.EquipmentName3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EtypeName3
            // 
            this.EtypeName3.DataPropertyName = "etypename";
            this.EtypeName3.HeaderText = "设备类型";
            this.EtypeName3.Name = "EtypeName3";
            this.EtypeName3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PtypeName3
            // 
            this.PtypeName3.DataPropertyName = "ptypename";
            this.PtypeName3.HeaderText = "协议类型";
            this.PtypeName3.Name = "PtypeName3";
            this.PtypeName3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OPCNodeName
            // 
            this.OPCNodeName.DataPropertyName = "opcnodename";
            this.OPCNodeName.HeaderText = "节点名称";
            this.OPCNodeName.Name = "OPCNodeName";
            this.OPCNodeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OPCServerName
            // 
            this.OPCServerName.DataPropertyName = "opccservername";
            this.OPCServerName.HeaderText = "服务器名称";
            this.OPCServerName.Name = "OPCServerName";
            // 
            // IsEnable3
            // 
            this.IsEnable3.DataPropertyName = "isenable";
            this.IsEnable3.HeaderText = "启用";
            this.IsEnable3.Name = "IsEnable3";
            // 
            // Comments3
            // 
            this.Comments3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comments3.DataPropertyName = "comments";
            this.Comments3.HeaderText = "备注";
            this.Comments3.Name = "Comments3";
            this.Comments3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comments3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Equipmentid3
            // 
            this.Equipmentid3.DataPropertyName = "equipmentid";
            this.Equipmentid3.HeaderText = "Equipmentid3";
            this.Equipmentid3.Name = "Equipmentid3";
            this.Equipmentid3.Visible = false;
            // 
            // Etypid3
            // 
            this.Etypid3.DataPropertyName = "etypeid";
            this.Etypid3.HeaderText = "Etypeid3";
            this.Etypid3.Name = "Etypid3";
            this.Etypid3.Visible = false;
            // 
            // Ptypeid3
            // 
            this.Ptypeid3.DataPropertyName = "ptypeid";
            this.Ptypeid3.HeaderText = "Ptypeid3";
            this.Ptypeid3.Name = "Ptypeid3";
            this.Ptypeid3.Visible = false;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsml_Update_OPC,
            this.tsmi_delete_OPCEquipment,
            this.toolStripSeparator3,
            this.tsml_Add_CGroup_OPC});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(218, 100);
            // 
            // tsml_Update_OPC
            // 
            this.tsml_Update_OPC.Name = "tsml_Update_OPC";
            this.tsml_Update_OPC.Size = new System.Drawing.Size(217, 30);
            this.tsml_Update_OPC.Text = "修改OPC设备";
            this.tsml_Update_OPC.Click += new System.EventHandler(this.tsml_Update_OPC_Click);
            // 
            // tsmi_delete_OPCEquipment
            // 
            this.tsmi_delete_OPCEquipment.Name = "tsmi_delete_OPCEquipment";
            this.tsmi_delete_OPCEquipment.Size = new System.Drawing.Size(217, 30);
            this.tsmi_delete_OPCEquipment.Text = "删除OPC设备";
            this.tsmi_delete_OPCEquipment.Click += new System.EventHandler(this.tsmi_delete_OPCEquipment_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(214, 6);
            // 
            // tsml_Add_CGroup_OPC
            // 
            this.tsml_Add_CGroup_OPC.Name = "tsml_Add_CGroup_OPC";
            this.tsml_Add_CGroup_OPC.Size = new System.Drawing.Size(217, 30);
            this.tsml_Add_CGroup_OPC.Text = "添加通信组配置";
            this.tsml_Add_CGroup_OPC.Click += new System.EventHandler(this.tsml_Add_CGroup_OPC_Click);
            // 
            // dgv_EquipMnetProt_SerialNo
            // 
            this.dgv_EquipMnetProt_SerialNo.AllowUserToAddRows = false;
            this.dgv_EquipMnetProt_SerialNo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EquipMnetProt_SerialNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_EquipMnetProt_SerialNo.ColumnHeadersHeight = 30;
            this.dgv_EquipMnetProt_SerialNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN2,
            this.EquipMentName2,
            this.EtypeName2,
            this.PtypeName2,
            this.SeriableNo2,
            this.Baudrate2,
            this.DataBit2,
            this.ParityBit2,
            this.StopBit2,
            this.IsEnable2,
            this.Comments2,
            this.Etypeid2,
            this.Ptypeid2,
            this.EquipmentId2});
            this.dgv_EquipMnetProt_SerialNo.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_EquipMnetProt_SerialNo.Location = new System.Drawing.Point(-1, 514);
            this.dgv_EquipMnetProt_SerialNo.Name = "dgv_EquipMnetProt_SerialNo";
            this.dgv_EquipMnetProt_SerialNo.RowHeadersVisible = false;
            this.dgv_EquipMnetProt_SerialNo.RowTemplate.Height = 23;
            this.dgv_EquipMnetProt_SerialNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_EquipMnetProt_SerialNo.Size = new System.Drawing.Size(928, 89);
            this.dgv_EquipMnetProt_SerialNo.TabIndex = 8;
            this.dgv_EquipMnetProt_SerialNo.Click += new System.EventHandler(this.dgv_EquipMnetProt_SerialNo_Click);
            this.dgv_EquipMnetProt_SerialNo.DoubleClick += new System.EventHandler(this.dgv_EquipMnetProt_SerialNo_DoubleClick);
            // 
            // SN2
            // 
            this.SN2.DataPropertyName = "SN";
            this.SN2.HeaderText = "序号";
            this.SN2.Name = "SN2";
            this.SN2.Width = 50;
            // 
            // EquipMentName2
            // 
            this.EquipMentName2.DataPropertyName = "equipmentname";
            this.EquipMentName2.HeaderText = "设备名称";
            this.EquipMentName2.Name = "EquipMentName2";
            this.EquipMentName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EtypeName2
            // 
            this.EtypeName2.DataPropertyName = "etypename";
            this.EtypeName2.HeaderText = "设备类型";
            this.EtypeName2.Name = "EtypeName2";
            this.EtypeName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PtypeName2
            // 
            this.PtypeName2.DataPropertyName = "ptypename";
            this.PtypeName2.HeaderText = "协议类型";
            this.PtypeName2.Name = "PtypeName2";
            this.PtypeName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SeriableNo2
            // 
            this.SeriableNo2.DataPropertyName = "serialno";
            this.SeriableNo2.HeaderText = "串口号";
            this.SeriableNo2.Name = "SeriableNo2";
            this.SeriableNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Baudrate2
            // 
            this.Baudrate2.DataPropertyName = "baudrate";
            this.Baudrate2.HeaderText = "波特率";
            this.Baudrate2.Name = "Baudrate2";
            this.Baudrate2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataBit2
            // 
            this.DataBit2.DataPropertyName = "databit";
            this.DataBit2.HeaderText = "数据位";
            this.DataBit2.Name = "DataBit2";
            this.DataBit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataBit2.Width = 60;
            // 
            // ParityBit2
            // 
            this.ParityBit2.DataPropertyName = "paritybit";
            this.ParityBit2.HeaderText = "校验位";
            this.ParityBit2.Name = "ParityBit2";
            this.ParityBit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ParityBit2.Width = 60;
            // 
            // StopBit2
            // 
            this.StopBit2.DataPropertyName = "stopbit";
            this.StopBit2.HeaderText = "停止位";
            this.StopBit2.Name = "StopBit2";
            this.StopBit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StopBit2.Width = 60;
            // 
            // IsEnable2
            // 
            this.IsEnable2.DataPropertyName = "isenable";
            this.IsEnable2.HeaderText = "启用";
            this.IsEnable2.Name = "IsEnable2";
            // 
            // Comments2
            // 
            this.Comments2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comments2.DataPropertyName = "comments";
            this.Comments2.HeaderText = "备注";
            this.Comments2.Name = "Comments2";
            this.Comments2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comments2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Etypeid2
            // 
            this.Etypeid2.DataPropertyName = "etypeid";
            this.Etypeid2.HeaderText = "Etypeid2";
            this.Etypeid2.Name = "Etypeid2";
            this.Etypeid2.Visible = false;
            // 
            // Ptypeid2
            // 
            this.Ptypeid2.DataPropertyName = "ptypeid";
            this.Ptypeid2.HeaderText = "Ptypeid2";
            this.Ptypeid2.Name = "Ptypeid2";
            this.Ptypeid2.Visible = false;
            // 
            // EquipmentId2
            // 
            this.EquipmentId2.DataPropertyName = "equipmentid";
            this.EquipmentId2.HeaderText = "Equipmentid2";
            this.EquipmentId2.Name = "EquipmentId2";
            this.EquipmentId2.Visible = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsml_Update_SerialPort,
            this.tsmi_delete_SerialEquipment,
            this.toolStripSeparator2,
            this.tsml_Add_CGroup_Serial});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(218, 100);
            // 
            // tsml_Update_SerialPort
            // 
            this.tsml_Update_SerialPort.Name = "tsml_Update_SerialPort";
            this.tsml_Update_SerialPort.Size = new System.Drawing.Size(217, 30);
            this.tsml_Update_SerialPort.Text = "修改串口设备";
            this.tsml_Update_SerialPort.Click += new System.EventHandler(this.tsml_Update_SerialPort_Click);
            // 
            // tsmi_delete_SerialEquipment
            // 
            this.tsmi_delete_SerialEquipment.Name = "tsmi_delete_SerialEquipment";
            this.tsmi_delete_SerialEquipment.Size = new System.Drawing.Size(217, 30);
            this.tsmi_delete_SerialEquipment.Text = "删除串口设备";
            this.tsmi_delete_SerialEquipment.Click += new System.EventHandler(this.tsmi_delete_SerialEquipment_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // tsml_Add_CGroup_Serial
            // 
            this.tsml_Add_CGroup_Serial.Name = "tsml_Add_CGroup_Serial";
            this.tsml_Add_CGroup_Serial.Size = new System.Drawing.Size(217, 30);
            this.tsml_Add_CGroup_Serial.Text = "添加通信组配置";
            this.tsml_Add_CGroup_Serial.Click += new System.EventHandler(this.tsml_Add_CGroup_Serial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(146, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "其他操作鼠标右键";
            // 
            // btnAddEquipMents
            // 
            this.btnAddEquipMents.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddEquipMents.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddEquipMents.Location = new System.Drawing.Point(13, 377);
            this.btnAddEquipMents.Name = "btnAddEquipMents";
            this.btnAddEquipMents.Size = new System.Drawing.Size(127, 36);
            this.btnAddEquipMents.TabIndex = 5;
            this.btnAddEquipMents.Text = "增加新设备";
            this.btnAddEquipMents.UseVisualStyleBackColor = true;
            this.btnAddEquipMents.Click += new System.EventHandler(this.btnAddEquipMents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(658, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "提示：点击设备列表，即可显示通信组";
            // 
            // dgv_CG
            // 
            this.dgv_CG.AllowUserToAddRows = false;
            this.dgv_CG.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CG.ColumnHeadersHeight = 30;
            this.dgv_CG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN4,
            this.EquipmentName4,
            this.CGName,
            this.StartAddRess,
            this.CGLength,
            this.IsEnable,
            this.Comments,
            this.CGid});
            this.dgv_CG.Location = new System.Drawing.Point(329, 73);
            this.dgv_CG.Name = "dgv_CG";
            this.dgv_CG.RowHeadersVisible = false;
            this.dgv_CG.RowTemplate.Height = 23;
            this.dgv_CG.Size = new System.Drawing.Size(603, 335);
            this.dgv_CG.TabIndex = 3;
            this.dgv_CG.DoubleClick += new System.EventHandler(this.dgv_CG_DoubleClick);
            // 
            // SN4
            // 
            this.SN4.DataPropertyName = "SN";
            this.SN4.HeaderText = "序号";
            this.SN4.Name = "SN4";
            this.SN4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SN4.Width = 50;
            // 
            // EquipmentName4
            // 
            this.EquipmentName4.DataPropertyName = "EquipmentName";
            this.EquipmentName4.HeaderText = "设备名称";
            this.EquipmentName4.Name = "EquipmentName4";
            this.EquipmentName4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EquipmentName4.Width = 80;
            // 
            // CGName
            // 
            this.CGName.DataPropertyName = "CGName";
            this.CGName.HeaderText = "通信组名";
            this.CGName.Name = "CGName";
            this.CGName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CGName.Width = 80;
            // 
            // StartAddRess
            // 
            this.StartAddRess.DataPropertyName = "StartAddRess";
            this.StartAddRess.HeaderText = "起始地址";
            this.StartAddRess.Name = "StartAddRess";
            this.StartAddRess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartAddRess.Width = 80;
            // 
            // CGLength
            // 
            this.CGLength.DataPropertyName = "CGLength";
            this.CGLength.HeaderText = "通信组长度";
            this.CGLength.Name = "CGLength";
            this.CGLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsEnable
            // 
            this.IsEnable.DataPropertyName = "ISEnable";
            this.IsEnable.HeaderText = "启用";
            this.IsEnable.Name = "IsEnable";
            this.IsEnable.Width = 80;
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "备注";
            this.Comments.Name = "Comments";
            this.Comments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CGid
            // 
            this.CGid.DataPropertyName = "cgid";
            this.CGid.HeaderText = "CGID";
            this.CGid.Name = "CGid";
            this.CGid.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete_CommunicationGroup);
            this.groupBox2.Controls.Add(this.btn_Update_CommunicationGroup);
            this.groupBox2.Location = new System.Drawing.Point(329, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信组配置";
            // 
            // btn_Delete_CommunicationGroup
            // 
            this.btn_Delete_CommunicationGroup.FlatAppearance.BorderSize = 0;
            this.btn_Delete_CommunicationGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_CommunicationGroup.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Delete_CommunicationGroup.Location = new System.Drawing.Point(151, 25);
            this.btn_Delete_CommunicationGroup.Name = "btn_Delete_CommunicationGroup";
            this.btn_Delete_CommunicationGroup.Size = new System.Drawing.Size(128, 27);
            this.btn_Delete_CommunicationGroup.TabIndex = 1;
            this.btn_Delete_CommunicationGroup.Text = "删除通信组";
            this.btn_Delete_CommunicationGroup.UseVisualStyleBackColor = true;
            this.btn_Delete_CommunicationGroup.Click += new System.EventHandler(this.btn_Delete_CommunicationGroup_Click);
            // 
            // btn_Update_CommunicationGroup
            // 
            this.btn_Update_CommunicationGroup.FlatAppearance.BorderSize = 0;
            this.btn_Update_CommunicationGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update_CommunicationGroup.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Update_CommunicationGroup.Location = new System.Drawing.Point(6, 25);
            this.btn_Update_CommunicationGroup.Name = "btn_Update_CommunicationGroup";
            this.btn_Update_CommunicationGroup.Size = new System.Drawing.Size(128, 27);
            this.btn_Update_CommunicationGroup.TabIndex = 0;
            this.btn_Update_CommunicationGroup.Text = "修改通信组";
            this.btn_Update_CommunicationGroup.UseVisualStyleBackColor = true;
            this.btn_Update_CommunicationGroup.Click += new System.EventHandler(this.btn_Update_CommunicationGroup_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProjects.ColumnHeadersHeight = 30;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.ProjectName,
            this.ProjectID});
            this.dgvProjects.Location = new System.Drawing.Point(7, 73);
            this.dgvProjects.Name = "dgvProjects";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.RowTemplate.Height = 23;
            this.dgvProjects.Size = new System.Drawing.Size(302, 286);
            this.dgvProjects.TabIndex = 1;
            this.dgvProjects.DataSourceChanged += new System.EventHandler(this.dgvProjects_DataSourceChanged);
            this.dgvProjects.DoubleClick += new System.EventHandler(this.dgvProjects_DoubleClick);
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "序号";
            this.SN.Name = "SN";
            this.SN.Width = 50;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.DataPropertyName = "projectname";
            this.ProjectName.HeaderText = "项目名称";
            this.ProjectName.Name = "ProjectName";
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "projectid";
            this.ProjectID.HeaderText = "项目编号";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProject);
            this.groupBox1.Controls.Add(this.btnUpdataProjectName);
            this.groupBox1.Controls.Add(this.btnNewProject);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目信息";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.FlatAppearance.BorderSize = 0;
            this.btnDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteProject.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProject.Location = new System.Drawing.Point(202, 25);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(86, 27);
            this.btnDeleteProject.TabIndex = 2;
            this.btnDeleteProject.Text = "删除";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnUpdataProjectName
            // 
            this.btnUpdataProjectName.FlatAppearance.BorderSize = 0;
            this.btnUpdataProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdataProjectName.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdataProjectName.Location = new System.Drawing.Point(104, 25);
            this.btnUpdataProjectName.Name = "btnUpdataProjectName";
            this.btnUpdataProjectName.Size = new System.Drawing.Size(86, 27);
            this.btnUpdataProjectName.TabIndex = 1;
            this.btnUpdataProjectName.Text = "重命名";
            this.btnUpdataProjectName.UseVisualStyleBackColor = true;
            this.btnUpdataProjectName.Click += new System.EventHandler(this.btnUpdataProjectName_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewProject.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btnNewProject.Location = new System.Drawing.Point(6, 25);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(86, 27);
            this.btnNewProject.TabIndex = 0;
            this.btnNewProject.Text = "创建项目";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // tal_faction
            // 
            this.tal_faction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tal_faction.Controls.Add(this.rtb);
            this.tal_faction.Controls.Add(this.btn_SaveDeviceFile);
            this.tal_faction.Location = new System.Drawing.Point(4, 31);
            this.tal_faction.Name = "tal_faction";
            this.tal_faction.Padding = new System.Windows.Forms.Padding(3);
            this.tal_faction.Size = new System.Drawing.Size(1791, 694);
            this.tal_faction.TabIndex = 1;
            this.tal_faction.Text = "功能扩展";
            this.tal_faction.UseVisualStyleBackColor = true;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(29, 71);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(1341, 574);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // btn_SaveDeviceFile
            // 
            this.btn_SaveDeviceFile.Location = new System.Drawing.Point(29, 30);
            this.btn_SaveDeviceFile.Name = "btn_SaveDeviceFile";
            this.btn_SaveDeviceFile.Size = new System.Drawing.Size(106, 35);
            this.btn_SaveDeviceFile.TabIndex = 0;
            this.btn_SaveDeviceFile.Text = "导出配置文件";
            this.btn_SaveDeviceFile.UseVisualStyleBackColor = true;
            this.btn_SaveDeviceFile.Click += new System.EventHandler(this.btn_SaveDeviceFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tlbleUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 729);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1799, 27);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 22);
            this.toolStripStatusLabel1.Text = "文憔悴仿作";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripStatusLabel2.Text = "当前用户：";
            // 
            // tlbleUser
            // 
            this.tlbleUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.tlbleUser.Name = "tlbleUser";
            this.tlbleUser.Size = new System.Drawing.Size(74, 22);
            this.tlbleUser.Text = "默认用户";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 756);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上位机配置软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMent_IPAddRess)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Variable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMent_OPC)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EquipMnetProt_SerialNo)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tal_faction.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tal_faction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnUpdataProjectName;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tlbleUser;
        private System.Windows.Forms.DataGridView dgv_CG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Delete_CommunicationGroup;
        private System.Windows.Forms.Button btn_Update_CommunicationGroup;
        private System.Windows.Forms.DataGridView dgv_EquipMent_IPAddRess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEquipMents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_EquipMent_OPC;
        private System.Windows.Forms.DataGridView dgv_EquipMnetProt_SerialNo;
        private System.Windows.Forms.DataGridView dgv_Variable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DeleteVariable;
        private System.Windows.Forms.Button btn_UpdateVariable;
        private System.Windows.Forms.Button btn_AddVariabl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsml_Update_Internet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete_IPEquipment;
        private System.Windows.Forms.ToolStripMenuItem tslm_Add_CGroup_Internet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsml_Update_SerialPort;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete_SerialEquipment;
        private System.Windows.Forms.ToolStripMenuItem tsml_Add_CGroup_Serial;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_delete_OPCEquipment;
        private System.Windows.Forms.ToolStripMenuItem tsml_Update_OPC;
        private System.Windows.Forms.ToolStripMenuItem tsml_Add_CGroup_OPC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipMentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ptypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtypeName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtypeName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPCNodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPCServerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnable3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipmentid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etypid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ptypeid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddRess;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGLength;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGid;
        private System.Windows.Forms.Button btn_ReadCSV;
        private System.Windows.Forms.Button btn_SaveCSV;
        private System.Windows.Forms.Button btn_SaveDeviceFile;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipMentName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtypeName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriableNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baudrate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParityBit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopBit2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etypeid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ptypeid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN5;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddRess1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMaxAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALarmMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmMaxNode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMinAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmMinNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offsetorlength;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Isfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variableid;
    }
}

