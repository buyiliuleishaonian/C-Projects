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
    /// 设备类型业务逻辑层
    /// </summary>
    public class EquipMentBLL
    {
        public EquipMentDAL equipMent=new EquipMentDAL();

        /// <summary>
        /// 查询所有设备类型
        /// </summary>
        /// <returns></returns>
        public List<EquipmenttypeModel> QueryEType()
        {
            return equipMent.QueryEType();
        }

        /// <summary>
        /// 按照设备类型查询通信协议
        /// </summary>
        /// <param name="eTypeID">设备类型ID</param>
        /// <returns></returns>
        public List<ProtocoltypeModel> QueryProtocolType(int eTypeID) 
        {
            return equipMent.QueryProtocolType(eTypeID);
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int InsertEquipMent(EquipmentsModel model)
        {
            return equipMent.InsertEquipMent(model);
        }

        /// <summary>
        /// 新增设备时，判断在同一个项目下，是否存在重复设备名
        /// </summary>
        /// <param name="EquipMentName">设备名</param>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        public bool IsRepareforInsert(string EquipMentName,int ProjectID)
        {
            return equipMent.IsRepeatforInsert(EquipMentName,ProjectID);
        }

        /// <summary>
        /// 根据项目对象显示设备类型
        /// </summary>
        /// <param name="projectid"></param>
        /// <returns></returns>
        public Dictionary<int, List<EquipmentsModel>> QueryEquipments(int projectid)
        {
            return equipMent.QueryEquipMent(projectid);
        }

        /// <summary>
        /// 修改EquipMent对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  bool  UpdateEquipMent(EquipmentsModel model)
        {
            return equipMent.UpdateEquipMent(model);
        }

        /// <summary>
        /// 判断修改设备类型的名称，是否在同一个项目里面，同一个设备类型里面重复
        /// </summary>
        /// <param name="equipmentName">设备类型名称</param>
        /// <param name="equipmentid">设备类型id</param>
        /// <param name="projectid">项目ID</param>
        /// <returns></returns>
        public bool IsRepareForUpdate(string equipmentName,int projectid,int equipmentid)
        {
            return equipMent.IsRepeatforUpdate(equipmentName,equipmentid,projectid);
        }

        /// <summary>
        /// 根据设备ID查询设备对象
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <returns></returns>
        public EquipmentsModel QueryEquipMent(int equipmentid)
        {
            return equipMent.QueryEquipment(equipmentid);
        }

        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="equipMentID"></param>
        /// <returns></returns>
        public bool DeleteEquipMent(int equipMentID)
        {
            return equipMent.DeleteEquipMent(equipMentID);
        }
    }
}
