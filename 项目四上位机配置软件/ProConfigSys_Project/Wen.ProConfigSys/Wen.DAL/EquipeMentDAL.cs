using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wen.Models;


namespace Wen.DAL
{
    /// <summary>
    /// 设备类型数据访问类
    /// </summary>
    public class EquipMentDAL
    {
        #region 设备类型和协议类型

        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <returns>设备类型集合</returns>
        public List<EquipmenttypeModel> QueryEType()
        {
            List<EquipmenttypeModel> list = new List<EquipmenttypeModel>();
            string sql = "select etypeid,etypename from equipmenttype";
            DataTable dt = SQLHelper.GetDataTable(sql, null);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new EquipmenttypeModel()
                    {
                        Etypeid = Convert.ToInt32(dr["etypeid"]),
                        Etypename = dr["etypeName"].ToString(),
                    });
                }
            }
            return list;
        }

        //根据设备类型来获取协议类型
        /// <summary>
        /// 根据设备类型来查询协议类型
        /// </summary>
        /// <param name="EtypeID">设备类型ID</param>
        /// <returns></returns>
        public List<ProtocoltypeModel> QueryProtocolType(int EtypeID)
        {
            List<ProtocoltypeModel> list = new List<ProtocoltypeModel>();
            string sql = "select ptypeid,etypeid,ptypename from protocoltype" +
                " where etypeid=@etypeid";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@etypeid",EtypeID)
            };
            DataTable dt = SQLHelper.GetDataTable(sql, param);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    list.Add(new ProtocoltypeModel()
                    {
                        PtypeId = Convert.ToInt32(item["ptypeid"]),
                        Etypeid = Convert.ToInt32(item["etypeid"]),
                        Ptypename = item["ptypename"].ToString()
                    });
                }
            }
            return list;
        }
        #endregion

        #region  添加新增设备，修改设备

        /// <summary>
        /// 添加新设备
        /// </summary>
        /// <param name="model">设备对象</param>
        /// <returns></returns>
        public int InsertEquipMent(EquipmentsModel model)
        {
            string sql = "insert into Equipments(ProjectID,EtypeID,PtypeID, " +
                " EquipMentName,IpAddress,PortNo,Serialno,BaudRate,DataBit, " +
                " ParityBit,StopBit,OPCNodeName,OPCserverName,IsEnable,Comments)";
            sql += "values(@ProjectID,@EtypeID,@PtypeID,@EquipMentName,@IpAddress,@PortNo,@Serialno,@BaudRate,@DataBit," +
                " @ParityBit,@StopBit,@OPCNodeName,@OPCserverName,@IsEnable,@Comments) ;" +
                " select @@identity";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ProjectID",model.Projectid),
                new SqlParameter("@EtypeID", model.Etypeid),
                new SqlParameter("@PtypeID",model.Ptypeid),
                new SqlParameter("@EquipMentName",model.EquipmentName),
                new SqlParameter("@IpAddress",model.Ipaddress),
                new SqlParameter("@PortNo",model.Portno),
                new SqlParameter("@Serialno",model.Serialno),
                new SqlParameter("@BaudRate",model.Baudrate),
                new SqlParameter("@DataBit",model.Databit),
                new SqlParameter("@ParityBit",model.Paritybit),
                new SqlParameter("@StopBit",model.Stopbit),
                new SqlParameter("@OPCNodeName",model.Opcnodename),
                new SqlParameter("@OPCserverName",model.Opcservername),
                new SqlParameter("@IsEnable",model.Isenable),
                new SqlParameter("@Comments",model.Comments)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, param));
        }

        /// <summary>
        /// 判断新增设备时，设备名是否重复
        /// </summary>
        /// <param name="EquipMentName">设备名</param>
        /// <param name="ProjectID">项目id</param>
        /// <returns></returns>
        public bool IsRepeatforInsert(string EquipMentName, int ProjectID)
        {
            //验证设备名，验证项目ID,需要保证在同一个项目下，不可以重复设备名
            string sql = "select count(*) from Equipments " +
                " where equipmentname=@equipmentname and  projectid=@projectid";
            SqlParameter[] param = new SqlParameter[]
            {
                new  SqlParameter("@equipmentname",EquipMentName),
                new SqlParameter("@projectid",ProjectID)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, param)) > 0 ? true : false;
        }

        #endregion


        //通过项目ID，查询所拥有的设备类型
        /// <summary>
        /// 项目ID——对应设备类型
        /// </summary>
        /// <param name="projectid">项目id</param>
        /// <returns></returns>
        public Dictionary<int, List<EquipmentsModel>> QueryEquipMent(int projectid)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select Equipmentid,projectid,equipmenttype.etypeid,protocoltype.ptypeid,");
            sql.AppendLine(" equipmentname,ipaddress,portno,Serialno,baudrate,databit,paritybit,stopbit,");
            sql.AppendLine(" opcnodename,opcservername,isenable,comments,etypename,ptypename");
            sql.AppendLine("from equipments");
            sql.AppendLine(" inner join  equipmenttype on equipmenttype.etypeid=equipments.etypeid");
            sql.AppendLine(" inner join  protocoltype  on protocoltype.ptypeid=equipments.ptypeid");
            sql.AppendLine(" where projectid=@projectid");

            string sql1 = sql.ToString();
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@projectid",projectid)
            };
            List<EquipmentsModel> listIPAddress = new List<EquipmentsModel>();
            List<EquipmentsModel> listSeriabl = new List<EquipmentsModel>();
            List<EquipmentsModel> listOPC = new List<EquipmentsModel>();
            Dictionary<int, List<EquipmentsModel>> dic = new Dictionary<int, List<EquipmentsModel>>()
            {
                [10] = listIPAddress,
                [11] = listSeriabl,
                [12] = listOPC,
            };
            DataTable dt = SQLHelper.GetDataTable(sql.ToString(), sqlparam);
            foreach (DataRow dr in dt.Rows)
            {
                switch (Convert.ToInt32(dr["etypeid"]))
                {
                    case 10:
                        dic[10].Add(new EquipmentsModel()
                        {
                            SN = dic[10].Count + 1,
                            EquipmentName = dr["equipmentname"].ToString(),
                            Equipmentid = Convert.ToInt32(dr["equipmentid"]),
                            Etypeid = Convert.ToInt32(dr["etypeid"]),
                            Projectid = Convert.ToInt32(dr["projectid"]),
                            Ptypeid = Convert.ToInt32(dr["ptypeid"]),
                            Ipaddress = dr["ipaddress"].ToString(),
                            Portno = dr["portno"].ToString(),
                            Isenable = Convert.ToInt32(dr["isenable"]),
                            Comments = dr["comments"].ToString(),

                            EtypeName = dr["etypename"].ToString(),
                            PtypeName = dr["ptypename"].ToString(),

                        });
                        break;
                    case 11:
                        dic[11].Add(new EquipmentsModel()
                        {
                            SN = dic[11].Count + 1,
                            EquipmentName = dr["equipmentname"].ToString(),
                            Equipmentid = Convert.ToInt32(dr["equipmentid"]),
                            Etypeid = Convert.ToInt32(dr["etypeid"]),
                            Projectid = Convert.ToInt32(dr["projectid"]),
                            Ptypeid = Convert.ToInt32(dr["ptypeid"]),
                            Serialno = dr["Serialno"].ToString(),
                            Baudrate = Convert.ToInt32(dr["baudrate"]),
                            Databit = Convert.ToInt32(dr["databit"]),
                            Paritybit = dr["paritybit"].ToString(),
                            Stopbit = Convert.ToInt32(dr["stopbit"]),

                            Isenable = Convert.ToInt32(dr["isenable"]),
                            Comments = dr["comments"].ToString(),
                            EtypeName = dr["etypename"].ToString(),
                            PtypeName = dr["ptypename"].ToString(),
                        });
                        break;
                    case 12:
                        dic[12].Add(new EquipmentsModel()
                        {
                            SN = dic[12].Count + 1,
                            EquipmentName = dr["equipmentname"].ToString(),
                            Equipmentid = Convert.ToInt32(dr["equipmentid"]),
                            Etypeid = Convert.ToInt32(dr["etypeid"]),
                            Projectid = Convert.ToInt32(dr["projectid"]),
                            Ptypeid = Convert.ToInt32(dr["ptypeid"]),
                            Opcservername = dr["opcservername"].ToString(),
                            Opcnodename = dr["opcnodename"].ToString(),
                            Isenable = Convert.ToInt32(dr["isenable"]),
                            Comments = dr["comments"].ToString(),
                            EtypeName = dr["etypename"].ToString(),
                            PtypeName = dr["ptypename"].ToString(),
                        });
                        break;
                    default:
                        break;
                }
            }
            return dic;
        }


        /// <summary>
        /// 修改新的设备类型
        /// </summary>
        /// <param name="model">设备类型</param>
        /// <returns></returns>
        public bool UpdateEquipMent(EquipmentsModel model)
        {
            //通用修改，设备的所有可变类型，本来保持不变的传过来的数据没有改变
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Update equipments");
            sb.AppendLine("  set equipmentname=@equipmentname,etypeid=@etypeid,ptypeid=@ptypeid,isenable=@isenable,comments=@comments,");
            sb.AppendLine(" ipaddress=@ipaddress,portno=@portno,");
            sb.AppendLine(" Serialno=@Serialno,baudrate=@baudrate,databit=@databit,paritybit=@paritybit,stopbit=@stopbit,");
            sb.AppendLine(" opcnodename=@opcnodename,opcservername=@opcservername ");
            sb.AppendLine(" where equipmentid=@equipmentid ");
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@equipmentname",model.EquipmentName),
                new SqlParameter("@equipmentid",model.Equipmentid),
                new SqlParameter("@etypeid",model.Etypeid),
                new SqlParameter("@ptypeid",model.Ptypeid),
                new SqlParameter("@isenable",model.Isenable),
                new SqlParameter("@comments",model.Comments),
                new SqlParameter("@ipaddress",model.Ipaddress),
                new SqlParameter("@portno",model.Portno),
                new SqlParameter("@Serialno",model.Serialno),
                new SqlParameter("@baudrate",model.Baudrate),
                new SqlParameter("@databit",model.Databit),
                new SqlParameter("@paritybit",model.Paritybit),
                new SqlParameter("@stopbit",model.Stopbit),
                new SqlParameter("@opcnodename",model.Opcnodename),
                new SqlParameter("@opcservername",model.Opcservername),
            };
            return SQLHelper.GetExecuteNonQuery(sb.ToString(), sqlparam) > 0 ? true : false;

        }

        /// <summary>
        /// 判断修改设备类型的名称，是否在同一个项目里面，同一个设备类型里面重复
        /// </summary>
        /// <param name="equipmentName">设备类型名称</param>
        /// <param name="equipmentId">设备类型id</param>
        /// <param name="projectId">项目ID</param>
        /// <returns></returns>
        public bool IsRepeatforUpdate(string equipmentName,int equipmentId,int projectId)
        {
            string sql = "select count(*) from equipments where equipmentName=@equipmentName and projectid=@projectid and equipmentid<>@equipmentid";
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@equipmentName",equipmentName),
                new SqlParameter("@projectid",projectId),
                new SqlParameter("@equipmentid",equipmentId)
            };
            return Convert.ToInt32( SQLHelper.GetExecuteScalar(sql,sqlparam))>0?true:false;
        }

        /// <summary>
        /// 根据设备ID，来查询设备类型以及通信协议
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <returns></returns>
        public EquipmentsModel QueryEquipment(int equipmentid)
        {
            EquipmentsModel equ = new EquipmentsModel();
            string sql = "select equipmentid,projects.ProjectID,EtypeID,PtypeID, " +
               " EquipMentName,IpAddress,PortNo,Serialno,BaudRate,DataBit, " +
               " ParityBit,StopBit,OPCNodeName,OPCserverName,IsEnable,Comments,projectname" +
               " from equipments" +
               " inner join  projects on projects.projectid=equipments.projectid" +
               " where equipmentid=@equipmentid";
            SqlParameter[] sqlparam = new SqlParameter[]
            {
                new SqlParameter("@equipmentid",equipmentid)
            };
            SqlDataReader read = SQLHelper.GetExecuteRead(sql, sqlparam);
            if (read.Read())
            {
                equ = new EquipmentsModel()
                {
                    Projectid = Convert.ToInt32(read["projectid"]),
                    Etypeid = Convert.ToInt32(read["etypeid"]),
                    Ptypeid = Convert.ToInt32(read["ptypeid"]),
                    Equipmentid = Convert.ToInt32(read["equipmentid"]),
                    EquipmentName = read["equipmentname"].ToString(),
                    Ipaddress = read["ipaddress"].ToString(),
                    Portno = read["portno"].ToString(),
                    Serialno = read["Serialno"].ToString(),
                    Baudrate = Convert.ToInt32(read["baudrate"]),
                    Databit = Convert.ToInt32(read["databit"]),
                    Paritybit = read["paritybit"].ToString(),
                    Stopbit = Convert.ToInt32(read["stopbit"]),
                    Opcnodename = read["opcnodename"].ToString(),
                    Opcservername = read["opcservername"].ToString(),
                    Isenable = Convert.ToInt32( read["isenable"]),
                    Comments = read["comments"].ToString(),
                    ProjectName = read["projectname"].ToString()
                };
            }
            read.Close();
            return equ;
        }

        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="equipmentid"></param>
        /// <returns></returns>

        public bool DeleteEquipMent(int equipmentid)
        {
            string sql = "delete from equipments" +
                " where equipmentid=@equipmentid";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@equipmentid",equipmentid)
            };
            return SQLHelper.GetExecuteNonQuery(sql, parameters)>0;
        }
    }
}
