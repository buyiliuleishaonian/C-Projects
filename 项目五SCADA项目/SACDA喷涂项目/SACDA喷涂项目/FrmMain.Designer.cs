using HZY.Framework.DependencyInjection;

namespace SACDA喷涂项目
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pal_Title = new Sunny.UI.UIPanel();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            lbl_time = new Sunny.UI.UILabel();
            lbl_Humidness = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            st_AlarmInfo = new Sunny.UI.UIScrollingText();
            lbl_UserName = new Sunny.UI.UILabel();
            pictureBox2 = new PictureBox();
            lbl_Subhead = new Sunny.UI.UILabel();
            lbl_Title = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            uiLabel4 = new Sunny.UI.UILabel();
            lbl_ProductCount = new Sunny.UI.UILedLabel();
            uiLabel5 = new Sunny.UI.UILabel();
            lbl_Badcount = new Sunny.UI.UILedLabel();
            uiLabel6 = new Sunny.UI.UILabel();
            lbl_Beat = new Sunny.UI.UILedLabel();
            uiLabel7 = new Sunny.UI.UILabel();
            lbl_AlarmCount = new Sunny.UI.UILedLabel();
            uiLabel8 = new Sunny.UI.UILabel();
            lbl_ProductState = new Sunny.UI.UILedBulb();
            uiLabel9 = new Sunny.UI.UILabel();
            lbl_ConnectState = new Sunny.UI.UILedBulb();
            uiLabel10 = new Sunny.UI.UILabel();
            lbl_CPUInformation = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            lbl_MemoryInformation = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            lbl_SoftwareVersion = new Sunny.UI.UILabel();
            uiLabel15 = new Sunny.UI.UILabel();
            lbl_IsAuthorization = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            lbl_Deadline = new Sunny.UI.UILabel();
            uiStyleManager = new Sunny.UI.UIStyleManager(components);
            Footer.SuspendLayout();
            Header.SuspendLayout();
            pal_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Controls.Add(lbl_Deadline);
            Footer.Controls.Add(uiLabel12);
            Footer.Controls.Add(lbl_IsAuthorization);
            Footer.Controls.Add(uiLabel15);
            Footer.Controls.Add(lbl_SoftwareVersion);
            Footer.Controls.Add(uiLabel13);
            Footer.Controls.Add(lbl_MemoryInformation);
            Footer.Controls.Add(uiLabel11);
            Footer.Controls.Add(lbl_CPUInformation);
            Footer.Controls.Add(uiLabel10);
            Footer.Controls.Add(lbl_ConnectState);
            Footer.Controls.Add(uiLabel9);
            Footer.Location = new Point(165, 664);
            Footer.Size = new Size(1115, 56);
            Footer.MouseDown += FraMain_MouseDown;
            Footer.MouseMove += FraMain_MouseMove;
            // 
            // Aside
            // 
            Aside.Location = new Point(0, 115);
            Aside.Size = new Size(165, 605);
            Aside.MouseDown += FraMain_MouseDown;
            Aside.MouseMove += FraMain_MouseMove;
            // 
            // Header
            // 
            Header.Controls.Add(lbl_ProductState);
            Header.Controls.Add(uiLabel8);
            Header.Controls.Add(lbl_AlarmCount);
            Header.Controls.Add(uiLabel7);
            Header.Controls.Add(lbl_Beat);
            Header.Controls.Add(uiLabel6);
            Header.Controls.Add(lbl_Badcount);
            Header.Controls.Add(uiLabel5);
            Header.Controls.Add(lbl_ProductCount);
            Header.Controls.Add(uiLabel4);
            Header.Controls.Add(pal_Title);
            Header.Location = new Point(0, 0);
            Header.NodeInterval = 0;
            Header.NodeSize = new Size(70, 50);
            Header.Size = new Size(1280, 115);
            Header.MenuItemClick += Header_MenuItemClick;
            Header.MouseDown += FraMain_MouseDown;
            Header.MouseMove += FraMain_MouseMove;
            // 
            // pal_Title
            // 
            pal_Title.Controls.Add(uiSymbolLabel2);
            pal_Title.Controls.Add(uiSymbolLabel1);
            pal_Title.Controls.Add(uiLabel2);
            pal_Title.Controls.Add(uiLabel3);
            pal_Title.Controls.Add(lbl_time);
            pal_Title.Controls.Add(lbl_Humidness);
            pal_Title.Controls.Add(uiLabel1);
            pal_Title.Controls.Add(st_AlarmInfo);
            pal_Title.Controls.Add(lbl_UserName);
            pal_Title.Controls.Add(pictureBox2);
            pal_Title.Controls.Add(lbl_Subhead);
            pal_Title.Controls.Add(lbl_Title);
            pal_Title.Controls.Add(pictureBox1);
            pal_Title.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pal_Title.Location = new Point(4, 5);
            pal_Title.Margin = new Padding(4, 5, 4, 5);
            pal_Title.MinimumSize = new Size(1, 1);
            pal_Title.Name = "pal_Title";
            pal_Title.Size = new Size(1272, 58);
            pal_Title.TabIndex = 0;
            pal_Title.Text = null;
            pal_Title.TextAlignment = ContentAlignment.MiddleCenter;
            pal_Title.MouseDown += FraMain_MouseDown;
            pal_Title.MouseMove += FraMain_MouseMove;
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.BackColor = Color.Transparent;
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel2.ForeColor = Color.Transparent;
            uiSymbolLabel2.Location = new Point(1209, 8);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(59, 35);
            uiSymbolLabel2.Symbol = 61453;
            uiSymbolLabel2.SymbolSize = 45;
            uiSymbolLabel2.TabIndex = 12;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.ForeColor = Color.Transparent;
            uiSymbolLabel1.Location = new Point(1144, 8);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(59, 35);
            uiSymbolLabel1.Symbol = 61544;
            uiSymbolLabel1.SymbolSize = 45;
            uiSymbolLabel1.TabIndex = 11;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.Green;
            uiLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel2.Location = new Point(1063, 1);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(44, 32);
            uiLabel2.TabIndex = 10;
            uiLabel2.Text = "60%";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("宋体", 9F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Image = Properties.Resources.湿度;
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(973, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(84, 32);
            uiLabel3.TabIndex = 9;
            uiLabel3.Text = "厂房湿度";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_time
            // 
            lbl_time.BackColor = Color.Transparent;
            lbl_time.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_time.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_time.Location = new Point(820, 29);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(189, 23);
            lbl_time.TabIndex = 8;
            lbl_time.Text = "2024-10-12-23:05:23";
            lbl_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Humidness
            // 
            lbl_Humidness.BackColor = Color.Transparent;
            lbl_Humidness.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_Humidness.ForeColor = Color.Red;
            lbl_Humidness.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_Humidness.Location = new Point(935, 2);
            lbl_Humidness.Name = "lbl_Humidness";
            lbl_Humidness.Size = new Size(44, 32);
            lbl_Humidness.TabIndex = 7;
            lbl_Humidness.Text = "25℃";
            lbl_Humidness.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 9F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Image = Properties.Resources.温度;
            uiLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel1.Location = new Point(845, 1);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(84, 32);
            uiLabel1.TabIndex = 6;
            uiLabel1.Text = "厂房温度";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // st_AlarmInfo
            // 
            st_AlarmInfo.Active = true;
            st_AlarmInfo.Font = new Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            st_AlarmInfo.Location = new Point(496, 8);
            st_AlarmInfo.MinimumSize = new Size(1, 1);
            st_AlarmInfo.Name = "st_AlarmInfo";
            st_AlarmInfo.Size = new Size(318, 41);
            st_AlarmInfo.Style = Sunny.UI.UIStyle.Custom;
            st_AlarmInfo.TabIndex = 5;
            st_AlarmInfo.Text = "系统正常";
            // 
            // lbl_UserName
            // 
            lbl_UserName.BackColor = Color.Transparent;
            lbl_UserName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lbl_UserName.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_UserName.Location = new Point(403, 11);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(87, 37);
            lbl_UserName.TabIndex = 4;
            lbl_UserName.Text = "阿文";
            lbl_UserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.用户;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(348, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbl_Subhead
            // 
            lbl_Subhead.BackColor = Color.Transparent;
            lbl_Subhead.Font = new Font("宋体", 12F);
            lbl_Subhead.ForeColor = SystemColors.Highlight;
            lbl_Subhead.Location = new Point(82, 36);
            lbl_Subhead.Name = "lbl_Subhead";
            lbl_Subhead.Size = new Size(232, 23);
            lbl_Subhead.TabIndex = 2;
            lbl_Subhead.Text = "Spray Process SCADA System";
            lbl_Subhead.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("宋体", 21.75F);
            lbl_Title.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Title.Location = new Point(63, 2);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(279, 35);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "喷涂工艺SACDA系统";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.喷涂生产;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("宋体", 15F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Image = Properties.Resources.产量;
            uiLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel4.Location = new Point(5, 74);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(134, 32);
            uiLabel4.TabIndex = 1;
            uiLabel4.Text = "生产计数";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ProductCount
            // 
            lbl_ProductCount.BackColor = Color.Transparent;
            lbl_ProductCount.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_ProductCount.Location = new Point(144, 73);
            lbl_ProductCount.MinimumSize = new Size(1, 1);
            lbl_ProductCount.Name = "lbl_ProductCount";
            lbl_ProductCount.Size = new Size(100, 35);
            lbl_ProductCount.TabIndex = 2;
            lbl_ProductCount.Text = "5000";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("宋体", 15F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Image = Properties.Resources.产量;
            uiLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel5.Location = new Point(249, 74);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(134, 32);
            uiLabel5.TabIndex = 3;
            uiLabel5.Text = "不良计数";
            uiLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Badcount
            // 
            lbl_Badcount.BackColor = Color.Transparent;
            lbl_Badcount.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_Badcount.Location = new Point(388, 73);
            lbl_Badcount.MinimumSize = new Size(1, 1);
            lbl_Badcount.Name = "lbl_Badcount";
            lbl_Badcount.Size = new Size(100, 35);
            lbl_Badcount.TabIndex = 4;
            lbl_Badcount.Text = "5000";
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("宋体", 15F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Image = Properties.Resources.生产节拍;
            uiLabel6.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel6.Location = new Point(493, 74);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(134, 32);
            uiLabel6.TabIndex = 5;
            uiLabel6.Text = "生产节拍";
            uiLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Beat
            // 
            lbl_Beat.BackColor = Color.Transparent;
            lbl_Beat.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_Beat.Location = new Point(623, 71);
            lbl_Beat.MinimumSize = new Size(1, 1);
            lbl_Beat.Name = "lbl_Beat";
            lbl_Beat.Size = new Size(100, 35);
            lbl_Beat.TabIndex = 6;
            lbl_Beat.Text = "60s";
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("宋体", 15F);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Image = Properties.Resources.报警数;
            uiLabel7.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel7.Location = new Point(714, 74);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(134, 32);
            uiLabel7.TabIndex = 7;
            uiLabel7.Text = "累计报警";
            uiLabel7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_AlarmCount
            // 
            lbl_AlarmCount.BackColor = Color.Transparent;
            lbl_AlarmCount.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_AlarmCount.Location = new Point(849, 71);
            lbl_AlarmCount.MinimumSize = new Size(1, 1);
            lbl_AlarmCount.Name = "lbl_AlarmCount";
            lbl_AlarmCount.Size = new Size(75, 35);
            lbl_AlarmCount.TabIndex = 8;
            lbl_AlarmCount.Text = "20";
            // 
            // uiLabel8
            // 
            uiLabel8.BackColor = Color.Transparent;
            uiLabel8.Font = new Font("宋体", 15F);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Image = Properties.Resources.系统状态;
            uiLabel8.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel8.Location = new Point(916, 74);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(134, 32);
            uiLabel8.TabIndex = 9;
            uiLabel8.Text = "系统状态";
            uiLabel8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ProductState
            // 
            lbl_ProductState.BackColor = Color.Transparent;
            lbl_ProductState.Location = new Point(1055, 74);
            lbl_ProductState.Name = "lbl_ProductState";
            lbl_ProductState.Size = new Size(32, 32);
            lbl_ProductState.TabIndex = 10;
            lbl_ProductState.Text = "uiLedBulb1";
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Image = Properties.Resources.连接状态;
            uiLabel9.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel9.Location = new Point(15, 11);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(134, 32);
            uiLabel9.TabIndex = 0;
            uiLabel9.Text = "PLC连接状态";
            uiLabel9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ConnectState
            // 
            lbl_ConnectState.Location = new Point(162, 12);
            lbl_ConnectState.Name = "lbl_ConnectState";
            lbl_ConnectState.Size = new Size(32, 32);
            lbl_ConnectState.TabIndex = 11;
            lbl_ConnectState.Text = "uiLedBulb1";
            // 
            // uiLabel10
            // 
            uiLabel10.BackColor = Color.Transparent;
            uiLabel10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel10.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel10.Image = Properties.Resources.CPU信息;
            uiLabel10.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel10.Location = new Point(209, 11);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(104, 32);
            uiLabel10.TabIndex = 12;
            uiLabel10.Text = "CPU信息";
            uiLabel10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_CPUInformation
            // 
            lbl_CPUInformation.BackColor = Color.Transparent;
            lbl_CPUInformation.Font = new Font("宋体", 14.25F);
            lbl_CPUInformation.ForeColor = Color.Red;
            lbl_CPUInformation.Location = new Point(318, 15);
            lbl_CPUInformation.Name = "lbl_CPUInformation";
            lbl_CPUInformation.Size = new Size(61, 23);
            lbl_CPUInformation.TabIndex = 13;
            lbl_CPUInformation.Text = "50%";
            lbl_CPUInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel11
            // 
            uiLabel11.BackColor = Color.Transparent;
            uiLabel11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel11.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel11.Image = Properties.Resources.内存信息;
            uiLabel11.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel11.Location = new Point(386, 11);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(104, 32);
            uiLabel11.TabIndex = 14;
            uiLabel11.Text = "内存信息";
            uiLabel11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_MemoryInformation
            // 
            lbl_MemoryInformation.BackColor = Color.Transparent;
            lbl_MemoryInformation.Font = new Font("宋体", 14.25F);
            lbl_MemoryInformation.ForeColor = Color.Red;
            lbl_MemoryInformation.Location = new Point(496, 14);
            lbl_MemoryInformation.Name = "lbl_MemoryInformation";
            lbl_MemoryInformation.Size = new Size(61, 23);
            lbl_MemoryInformation.TabIndex = 15;
            lbl_MemoryInformation.Text = "70%";
            lbl_MemoryInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel13
            // 
            uiLabel13.BackColor = Color.Transparent;
            uiLabel13.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel13.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel13.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel13.Location = new Point(549, 11);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new Size(104, 32);
            uiLabel13.TabIndex = 16;
            uiLabel13.Text = "软件版本";
            uiLabel13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SoftwareVersion
            // 
            lbl_SoftwareVersion.BackColor = Color.Transparent;
            lbl_SoftwareVersion.Font = new Font("宋体", 14.25F);
            lbl_SoftwareVersion.ForeColor = Color.Red;
            lbl_SoftwareVersion.Location = new Point(641, 15);
            lbl_SoftwareVersion.Name = "lbl_SoftwareVersion";
            lbl_SoftwareVersion.Size = new Size(61, 23);
            lbl_SoftwareVersion.TabIndex = 17;
            lbl_SoftwareVersion.Text = "1.0";
            lbl_SoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel15
            // 
            uiLabel15.BackColor = Color.Transparent;
            uiLabel15.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel15.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel15.Image = Properties.Resources.授权;
            uiLabel15.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel15.Location = new Point(709, 11);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new Size(104, 32);
            uiLabel15.TabIndex = 18;
            uiLabel15.Text = "是否授权";
            uiLabel15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_IsAuthorization
            // 
            lbl_IsAuthorization.BackColor = Color.Transparent;
            lbl_IsAuthorization.Font = new Font("宋体", 14.25F);
            lbl_IsAuthorization.ForeColor = Color.Red;
            lbl_IsAuthorization.Location = new Point(811, 15);
            lbl_IsAuthorization.Name = "lbl_IsAuthorization";
            lbl_IsAuthorization.Size = new Size(61, 23);
            lbl_IsAuthorization.TabIndex = 19;
            lbl_IsAuthorization.Text = "否";
            lbl_IsAuthorization.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel12
            // 
            uiLabel12.BackColor = Color.Transparent;
            uiLabel12.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel12.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel12.Image = Properties.Resources.授权;
            uiLabel12.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel12.Location = new Point(879, 11);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(104, 32);
            uiLabel12.TabIndex = 20;
            uiLabel12.Text = "使用期限";
            uiLabel12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Deadline
            // 
            lbl_Deadline.BackColor = Color.Transparent;
            lbl_Deadline.Font = new Font("宋体", 14.25F);
            lbl_Deadline.ForeColor = Color.Red;
            lbl_Deadline.Location = new Point(996, 15);
            lbl_Deadline.Name = "lbl_Deadline";
            lbl_Deadline.Size = new Size(106, 23);
            lbl_Deadline.TabIndex = 21;
            lbl_Deadline.Text = "使用5m";
            lbl_Deadline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiStyleManager
            // 
            uiStyleManager.DPIScale = true;
            uiStyleManager.GlobalFont = true;
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            CloseAskString = "是否关闭系统";
            EscClose = true;
            Name = "FrmMain";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "FrmMain";
            ZoomScaleRect = new Rectangle(22, 22, 1618, 844);
            MouseDown += FraMain_MouseDown;
            MouseMove += FraMain_MouseMove;
            Footer.ResumeLayout(false);
            Header.ResumeLayout(false);
            pal_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pal_Title;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel lbl_Title;
        private Sunny.UI.UILabel lbl_UserName;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel lbl_Subhead;
        private Sunny.UI.UIScrollingText st_AlarmInfo;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbl_time;
        private Sunny.UI.UILabel lbl_Humidness;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILedLabel lbl_ProductCount;
        private Sunny.UI.UILedLabel lbl_Beat;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILedLabel lbl_Badcount;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILedBulb lbl_ProductState;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILedLabel lbl_AlarmCount;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILedBulb lbl_ConnectState;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel lbl_MemoryInformation;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel lbl_CPUInformation;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel lbl_SoftwareVersion;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel lbl_IsAuthorization;
        private Sunny.UI.UILabel lbl_Deadline;
        private Sunny.UI.UIStyleManager uiStyleManager;
    }
}
