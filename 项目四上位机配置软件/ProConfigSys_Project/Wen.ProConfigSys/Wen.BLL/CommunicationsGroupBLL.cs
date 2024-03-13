using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wen.DAL;
using Wen.Models;

namespace Wen.BLL
{
    /// <summary>
    /// 通信组的业务逻辑层
    /// </summary>
    public class CommunicationsGroupBLL
    {
        /// <summary>
        /// 创建通信组数据访问属性，并new一个新对象
        /// </summary>
        private CommunicationsGroupDAL CGDAL { get; set; }=new CommunicationsGroupDAL();

        /// <summary>
        /// 添加通信组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int InsertCommunication(CommunicationsgroupsModel model)
        {
            return CGDAL.InsertCommunicationGroup(model);
        }

        /// <summary>
        /// 判断添加新通信组的名称是否重复
        /// </summary>
        /// <param name="CgName"></param>
        /// <param name="equipmentID"></param>
        /// <returns></returns>
        public bool IsRepareForInsert(string CgName,int equipmentID,int projectid)
        {
            return CGDAL.IsRefareForInsert(CgName, equipmentID,projectid);
        }

        /// <summary>
        /// 查询一个设备——N个通信组
        /// </summary>
        /// <param name="equipmentid">设备ID</param>
        /// <returns></returns>

        public List<CommunicationsgroupsModel> SelectCommunticationGroup(int equipmentid)
        {
            return CGDAL.SelectCommunicationGroup(equipmentid);
        }


        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateCommunicationGroup(CommunicationsgroupsModel model)
        {
            return CGDAL.UpdateCommunicationGroup(model);
        }

        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <returns></returns>
        public bool DeleteCommunicationGroup(int equipmentid) 
        {
            return CGDAL.DeleteCommunictionGroup(equipmentid);
        }
    }
}
