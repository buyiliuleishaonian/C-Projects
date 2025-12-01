using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System;

using System.Collections.Generic;
using System.Windows.Forms;

namespace SACDA喷涂项目
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                //创建服务容器
                ServiceCollection service = new ServiceCollection();
                //注册服务
                ConfiguerService(service);
                //生产容器
                var container = service.BuildServiceProvider(new ServiceProviderOptions()
                {
                    ValidateScopes = true,
                    ValidateOnBuild = true
                });
                Global.serviceProvider = container;
                ApplicationConfiguration.Initialize();
                //通过容器调用服务
                var frmMain = container.GetRequiredService<FrmMain>();

                Application.Run(frmMain);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"程序启动失败，错误原因：{ex.Message}", "程序启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// 注册服务的方法
        /// </summary>
        /// <param name="service"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void ConfiguerService(ServiceCollection service)
        {
            //通过程序集来批量注册服务，前提是对应的程序集中的服务类型，满足服务的生命周期，即单例，作用域，周期，
            //当程序集不满足，让其可以通过继承其对应的接口如
            //注册自身类型，ISingletonSelfDependency,IScopedSelfDependency,ITransientSelfDependency
            //注册实现的接口映射，ISingletonDependency,IScopedDependency,ITransientDependency
            //如果此时调用了
            service.AddDependencyInjection(new List<Assembly>()
            {
                typeof(Program).Assembly
            });

            //这里手动单列服务FrmMain
            //service.AddSingleton<FrmMain>();    
        }
    }
}