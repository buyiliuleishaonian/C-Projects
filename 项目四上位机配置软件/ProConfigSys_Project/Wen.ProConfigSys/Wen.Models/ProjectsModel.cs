using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wen.Models
{
    /// <summary>
    /// 项目名称
    /// </summary>
    public class ProjectsModel
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int SN { get; set; }
        /// <summary>
        /// 项目序列ID
        /// </summary>
        public int Projectid { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Projectname { get; set; }

        //扩展外键，一个项目——N个设备
        /// <summary>
        /// 设备集合
        /// </summary>
        public List<EquipmentsModel> EquipmentMoedelList { get; set; }=new List<EquipmentsModel>();
    }
}

