using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wen.Models;

namespace Wen.ProConfigSysUI
{
    internal static class Program
    {
        public static  SysadminsModel Admin=new SysadminsModel();   
        /// <summary>
        /// 应用程序的主录口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Test测试，加密解密
            //string connectString1 = "server=.;database=ProConfigDB;user=jgw;pwd=123456;";
            //string connectString2=Common.StringSecurity.DESEncrypt(connectString1);
            //string connectString3=Common.StringSecurity.DESDecrypt(connectString2);
            //显示登录窗体
            //导入配置文件

            FrmAdminLogin frmAdminLogin = new FrmAdminLogin();
            if (frmAdminLogin.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

        }
    
    }
}
