using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using SACDA.Heaper;
using SACDA.Model;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace SACDA喷涂项目
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        /// <summary>
        /// 连接标志位
        /// </summary>
        public bool plcIsConnected = false;

        /// <summary>
        /// 线程取消令牌
        /// </summary>
        private CancellationTokenSource cts = new CancellationTokenSource();

        public FrmMain()
        {
            InitializeComponent();

            Init();
        }


        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            //初始化配置文件
            InitialIni();
            //初始化侧边栏
            InitialAside();
            //初始化顶部菜单栏
            InitialHeader();
            //读取PLC客户端配置
            InitialPLCClient();
        }

        /// <summary>
        /// 读取INI配置文件
        /// </summary>
        private void InitialIni()
        {
            Global.PLCInipath = Global.IniFile.ReadString("PLC参数", "PLC地址", Application.StartupPath + @"/PLC_var_config.xlsx");
            Global.CPUtype = (SiemensVersion)Enum.Parse(typeof(SiemensVersion), Global.IniFile.ReadString("PLC参数", "cpu类型", "S7_1200"));
            Global.IP = Global.IniFile.ReadString("PLC参数", "IP地址", "127.0.0.1");
            Global.Port = Global.IniFile.ReadInt("PLC参数", "端口号", 102);
            Global.Slot = Global.IniFile.ReadByte("PLC参数", "槽口号", 0);
            Global.Rack = Global.IniFile.ReadByte("PLC参数", "机架号", 0);
            Global.ReadTimeInterval = Global.IniFile.ReadInt("PLC参数", "读取间隔时间", 2000);
            Global.ConnectTimeout = Global.IniFile.ReadInt("PLC参数", "重连超时时间", 2000);
        }

        /// <summary>
        /// 读取PLC客户端配置
        /// </summary>
        private void InitialPLCClient()
        {


            var plcvarlist = MiniExcel.Query<PLCVarConfigModel>(Global.PLCInipath).ToList();

            Global.SiemensClient = new IoTClient.Clients.PLC.SiemensClient(Global.CPUtype, Global.IP, Global.Port, Global.Slot, Global.Rack, Global.ConnectTimeout);

            //连接PLC
            var result = Global.SiemensClient.Open();
            if (result.IsSucceed)
            {
                plcIsConnected = true;
                this.lbl_ConnectState.On = true;
            }
            else
            {
                plcIsConnected = false;
                this.lbl_ConnectState.On = false;
                return;
            }
            //添加plc读取字典，写入字典，数据字典
            for (int i = 0; i < plcvarlist.Count; i++)
            {
                Global.ReadDic.Add(plcvarlist[i].PLC地址, Enum.Parse<DataTypeEnum>(plcvarlist[i].变量类型, true));
                Global.WriteDic.Add(plcvarlist[i].名称, plcvarlist[i].PLC地址);
                Global.DataDic.Add(plcvarlist[i].名称, "NA");
            }

            try
            {
                //初始化PLC读取任务
                Task.Run(async () =>
                {
                    while (!cts.IsCancellationRequested)
                    {
                        if (plcIsConnected)
                        {
                            var dataResult = Global.SiemensClient.BatchRead(Global.ReadDic);
                            if (dataResult.IsSucceed)
                            {
                                for (global::System.Int32 i = 0; i < plcvarlist.Count; i++)
                                {
                                    Global.DataDic[plcvarlist[i].名称] = dataResult.Value[plcvarlist[i].PLC地址];
                                }
                            }
                            else
                            {
                                plcIsConnected = false;
                                this.Invoke(() =>
                                {
                                    this.lbl_ConnectState.On = false;
                                });
                            }
                            await Task.Delay(Global.ReadTimeInterval);
                        }
                        else
                        {
                            //重连plc
                            var reconnectResult = Global.SiemensClient.Open();
                            if (reconnectResult.IsSucceed)
                            {
                                plcIsConnected = true;
                                this.Invoke(() =>
                                {
                                    this.lbl_ConnectState.On = true;
                                });
                            }
                            else
                            {
                                plcIsConnected = false;
                                this.Invoke(() =>
                                {
                                    this.lbl_ConnectState.On = false;
                                });
                            }
                            await Task.Delay(Global.ReConnectTimeInterval);
                        }
                    }
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 初始化导航栏
        /// </summary>
        private void InitialAside()
        {
            //通过Sunnyui的窗体，UIHeaderAsideMainFooterFrame来实现通过侧边添加导航栏，
            //关联MainControl来实现页面切换

            #region 窗体切换

            Aside.TabControl = MainTabControl;

            //设置初始页面索引
            int pageIndex = 1000;

            //在Aside上创建节点，并且在MainTabControl上显示
            var equipmentNode = Aside.CreateNode("控制模块", 57397, 24, pageIndex);
            Aside.CreateChildNode(equipmentNode, AddPage(Global.serviceProvider.GetRequiredService<PageToalEquipmentControl>(), ++pageIndex));

            var RecipeNode = Aside.CreateNode("配方管理", 162333, 24, ++pageIndex);
            Aside.CreateChildNode(RecipeNode, AddPage(Global.serviceProvider.GetRequiredService<PageRecipeManage>(), ++pageIndex));

            var userNode = Aside.CreateNode("用户模块", 61447, 24, ++pageIndex);
            Aside.CreateChildNode(userNode, AddPage(Global.serviceProvider.GetRequiredService<PageUserManage>(), ++pageIndex));

            var toalNode = Aside.CreateNode("监控模块", 57397, 24, ++pageIndex);
            Aside.CreateChildNode(toalNode, AddPage(Global.serviceProvider.GetRequiredService<PageEquipmentMonitr>(), ++pageIndex));
            Aside.CreateChildNode(toalNode, AddPage(Global.serviceProvider.GetRequiredService<PageEquipmentMonitr1>(), ++pageIndex));
            Aside.CreateChildNode(toalNode, AddPage(Global.serviceProvider.GetRequiredService<PageEquipmentMonitr2>(), ++pageIndex));

            var logNode = Aside.CreateNode("日志模块", 162333, 24, ++pageIndex);
            Aside.CreateChildNode(logNode, AddPage(Global.serviceProvider.GetRequiredService<PageLogManage>(), ++pageIndex));

            var reportNode = Aside.CreateNode("报表模块", 57586, 24, ++pageIndex);
            Aside.CreateChildNode(reportNode, AddPage(Global.serviceProvider.GetRequiredService<PageReportManage>(), ++pageIndex));

            var chartNode = Aside.CreateNode("图表模块", 61950, 24, ++pageIndex);
            Aside.CreateChildNode(chartNode, AddPage(Global.serviceProvider.GetRequiredService<PageChartManage>(), ++pageIndex));

            var systemNode = Aside.CreateNode("参数模块", 559577, 24, ++pageIndex);
            Aside.CreateChildNode(systemNode, AddPage(Global.serviceProvider.GetRequiredService<PageSystemParameterSet>(), ++pageIndex));
            #endregion
        }

        /// <summary>
        /// 初始化顶部菜单栏
        /// </summary>
        private void InitialHeader()
        {

            //设置关联
            Header.TabControl = MainTabControl;

            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.SetNodeSymbol(Header.Nodes[0], 558295, 34);
            Header.SetNodeSymbol(Header.Nodes[1], 61489, 34);
            Header.SetNodeSymbol(Header.Nodes[2], 557925, 34);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[0], style.DisplayText(), style.Value());
            }

            //获取枚举FontsType的所有字体名称
            for (int i = 0; i < Enum.GetValues(typeof(SystemEnums.FontsType)).Length; i++)
            {
                Header.CreateChildNode(Header.Nodes[1], Enum.GetName(typeof(SystemEnums.FontsType), i), i + 1);
            }

            //获取枚举FontSize的所有字体大小  75-125的范围 75 80 85 90 95 100 105 110 115 120 125
            for (int i = 75; i <= 125; i += 5)
            {
                Header.CreateChildNode(Header.Nodes[2], i.ToString(), i);
            }

            //Header.NodeSelected += Header_NodeSelected;

            //UIStyles.DPIScale = true;
            //UIStyles.GlobalFont = true;
            //UIStyles.GlobalFontName = Header.Nodes[1].Text.ToString();
            //UIStyles.GlobalFontScale = Convert.ToInt32( Header.Nodes[2].Text);
            //UIStyles.SetDPIScale();


        }

        /// <summary>
        /// 菜单项点击事件，更改主题风格，字体，字体大小
        /// </summary>
        /// <param name="itemText">菜单栏文本</param>
        /// <param name="menuIndex">菜单栏索引</param>
        /// <param name="pageIndex">页面索引,从1开始</param>
        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            try
            {
                switch (menuIndex)
                {
                    case 0:
                        UIStyle style = (UIStyle)pageIndex;
                        uiStyleManager.Style = style; ;//主题
                        if (UIExtonsion.SetStyleManagerDelegate != null)
                        {
                            UIExtonsion.SetStyleManagerDelegate(uiStyleManager);
                        }
                        break;
                    case 1:
                        var fontname = Header.Nodes[1].Nodes[pageIndex - 1].Text.ToString();
                        UIStyles.GlobalFontName = fontname;//字体
                        UIStyles.GlobalFontScale = SystemConstant.SystemDufaultFontSlace;
                        UIStyles.SetDPIScale();
                        break;
                    case 2:
                        var result = pageIndex;
                        UIStyles.GlobalFontScale = Convert.ToInt32(result);//大小
                        UIStyles.SetDPIScale();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                var result = ex.Message;
            }

        }
        #endregion



        #region 窗体移动
        private Point point;
        /// <summary>
        /// 得到鼠标左键的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FraMain_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 通过鼠标移动的距离，加上窗体左上角坐标，减去鼠标坐标就是同步移动了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FraMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }
        #endregion


    }
}
