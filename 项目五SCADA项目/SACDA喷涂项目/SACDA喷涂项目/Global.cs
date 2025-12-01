using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sunny.UI;
using IoTClient.Clients.PLC;
using IoTClient.Common.Enums;
using IoTClient.Enums;

namespace SACDA喷涂项目
{
    /// <summary>
    /// 全局变量类
    /// </summary>
    public static class Global
    {
        /// <summary>
        /// 全局服务
        /// </summary>
        public static ServiceProvider serviceProvider;

        /// <summary>
        /// ini文件地址
        /// </summary>

        public static IniFile IniFile = new IniFile(Application.StartupPath + @"/Config.ini");

        /// <summary>
        /// PLC客户端
        /// </summary>

        public static SiemensClient SiemensClient;

        /// <summary>
        /// plcini文件路径
        /// </summary>
        public static string PLCInipath;

        /// <summary>
        /// Cpu类型
        /// </summary>
        public static SiemensVersion CPUtype;

        /// <summary>
        /// ip地址
        /// </summary>
        public static string IP;

        /// <summary>
        /// 端口号
        /// </summary>
        public static int Port;

        /// <summary>
        ///机架号
        /// </summary>
        public static byte Rack;

        /// <summary>
        /// 槽口号
        /// </summary>
        public static byte Slot;

        /// <summary>
        /// 读取间隔时间
        /// </summary>
        public static int ReadTimeInterval ;

        /// <summary>
        /// 连接超时
        /// </summary>
        public static int ConnectTimeout;


        /// <summary>
        /// 重连时间
        /// </summary>
        public static int ReConnectTimeInterval;

        /// <summary>
        /// PLC变量读取字典
        /// </summary>
        public static Dictionary<string, DataTypeEnum> ReadDic=new Dictionary<string, DataTypeEnum>();

        /// <summary>
        /// PLC变量的值字典
        /// </summary>
        public static Dictionary<string, object> DataDic=new Dictionary<string, object>();

        /// <summary>
        /// PLC变量写入字典
        /// </summary>
        public static Dictionary<string, object> WriteDic=new   Dictionary<string, object>();
    }
}
