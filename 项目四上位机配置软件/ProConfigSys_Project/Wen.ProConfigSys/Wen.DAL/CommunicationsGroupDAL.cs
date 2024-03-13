using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Wen.Models;
using System.Data;

namespace Wen.DAL
{
    /// <summary>
    /// 通信组数据访问层
    /// </summary>
    public class CommunicationsGroupDAL
    {
        //新增
        /// <summary>
        /// 新增通信组
        /// </summary>
        /// <param name="model">通信组对象</param>
        /// <returns></returns>
        public int InsertCommunicationGroup(CommunicationsgroupsModel model)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("insert into CommunicationsGroups");
            sql.AppendLine("(equipmentid,Cgname,StartAddRess,Cglength,Isenable,comments)");
            sql.AppendLine(" values(@equipmentid,@Cgname,@startaddress,@Cglength,@Isenable,@comments);");
            sql.AppendLine(" select @@identity");

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@equipmentid",model.Equipmentid),
                new SqlParameter("@Cgname",model.Cgname),
                new SqlParameter("@startaddress",model.Startaddress),
                new SqlParameter("@Cglength",model.Cglength),
                new SqlParameter("@Isenable",model.Isenable),
                new SqlParameter("@Comments",model.Comments)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql.ToString(), parameters));
        }

        //添加通信组，要求当前整个项目中，通信组名称必须唯一（通信组名称，项目编号）

        /// <summary>
        /// 验证添加通信组名称，在项目中唯一性(这里其实可以只需满足在一个项目中不存在同名的)
        /// </summary>
        /// <param name="CgName"></param>
        /// <param name="equipmentID"></param>
        /// <param name="projectid"></param>
        /// <returns></returns>
        public bool IsRefareForInsert(string CgName, int equipmentID, int projectid)
        {
            string sql = "select count(*)  from CommunicationsGroups" +
                " inner join  Equipments" +
                " on CommunicationsGroups.Equipmentid=Equipments.Equipmentid" +
                " inner join Projects" +
                " on Projects.projectid=Equipments.Projectid" +
                " where  projects.projectid=@projectid  and CgName=@CgName  and " +
                " ((Equipments.equipmentID<>@EquipmentID)  or (Equipments.equipmentID=@equipmentID))";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@equipmentID",equipmentID),
                new SqlParameter("@CgName",CgName),
                new SqlParameter("@projectid",projectid),
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, parameters)) > 0 ? true : false;
        }

        /// <summary>
        /// 查询一个设备所有的通信组
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <returns></returns>

        public List<CommunicationsgroupsModel> SelectCommunicationGroup(int equipmentid)
        {
            List<CommunicationsgroupsModel> list = new List<CommunicationsgroupsModel>();

            string sql = " select  Cgid,Equipmentid,Cgname,StartAddress,Cglength,Isenable,comments" +
                " from CommunicationsGroups" +
                " where equipmentid=@equipmentid";
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@equipmentid",equipmentid)
            };

            DataTable dt = SQLHelper.GetDataTable(sql, sqlparam);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new CommunicationsgroupsModel()
                {
                    SN = list.Count + 1,
                    Cgid = Convert.ToInt32(dr["cgid"]),
                    Equipmentid = Convert.ToInt32(dr["equipmentid"]),
                    Cgname = dr["cgname"].ToString(),
                    Startaddress = dr["startaddress"].ToString(),
                    Cglength = Convert.ToInt32(dr["cglength"]),
                    Isenable = Convert.ToInt32(dr["Isenable"]),
                    Comments = dr["Comments"].ToString(),
                });
            }
            return list;
        }

        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="model">通信组</param>
        /// <returns></returns>
        public bool UpdateCommunicationGroup(CommunicationsgroupsModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update communicationsgroups");
            sb.AppendLine(" set Cgname=@Cgname,startAddRess=@startAddRess,Cglength=@Cglength,Isenable=@ISenable,Comments=@Comments");
            sb.AppendLine(" where Cgid=@Cgid");
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@Cgname",model.Cgname),
                new SqlParameter("@startAddress",model.Startaddress),
                new SqlParameter("@Cglength",model.Cglength),
                new SqlParameter("@Isenable",model.Isenable),
                new SqlParameter("@Comments",model.Comments),
                new SqlParameter("@Cgid",model.Cgid),
            };
            return SQLHelper.GetExecuteNonQuery(sb.ToString(), sqlparam) > 0 ? true : false;
        }


        /// <summary>
        /// 同一个项目下，除去本身的名字，之外判断是否还存在同名通信组
        /// </summary>
        /// <param name="CgName">通信组名</param>
        /// <param name="CGid">通信组ID</param>
        /// <param name="projectid">项目ID</param>
        /// <returns></returns>
        public bool IsRefareForUPdate(string CgName, int CGid, int projectid)
        {
            string sql = "select count(*)  from CommunicationsGroups" +
                " inner join  Equipments" +
                " on CommunicationsGroups.Equipmentid=Equipments.Equipmentid" +
                " where  projects.projectid=@projectid  and CgName=@CgName  and " +
                " CGID<>@CGID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CGID",CGid),
                new SqlParameter("@CgName",CgName),
                new SqlParameter("@projectid",projectid),
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, parameters)) > 0 ? true : false;
        }

        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="CGid"></param>
        /// <returns></returns>
        public bool DeleteCommunictionGroup(int CGid)
        {
            string sql = "delete from CommunicationsGroups" +
                " where CGID=@CGID";
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@CGID",CGid)
            };
            return SQLHelper.GetExecuteNonQuery(sql,sqlparam)>0;
        }
    }
}
