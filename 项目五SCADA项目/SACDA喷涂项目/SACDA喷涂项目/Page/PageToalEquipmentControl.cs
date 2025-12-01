using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACDA喷涂项目
{
    public partial class PageToalEquipmentControl : UIPage,ISingletonSelfDependency

    {
        public PageToalEquipmentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 工位通用开关事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonDevice_ChangeClick(object sender, EventArgs e)
        {

        }
    }
}
