using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Wen.Models;

namespace Wen.DAL
{
    /// <summary>
    /// 变量数据访问
    /// </summary>
    public class VariableDAL
    {
        /// <summary>
        /// 添加变量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int InsertVariable(VariablesModel model)
        {
            string sql = "insert into Variables(VariableName,Cgid,StartAddRess,Datatype,IsmaxAlarm,IsminAlarm,AlarmMax," +
                " AlarmMin,Isfile,AlarmMaxNode,AlarmMinNode,Scale,OffsetorLength,Comments)" +
                " values(@VariableName,@Cgid,@StartAddRess,@DataType,@IsmaxAlarm," +
                " @IsminAlarm,@AlarmMax,@AlarmMin,@Isfile,@AlarmMaxNode,@AlarmMinNode," +
                " @Scale,@OffsetorLength,@Comments);select @@identity";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@VariableName",model.Variablename),
                new SqlParameter("@Cgid",model.Cgid),
                new SqlParameter("@StartAddRess",model.Startaddress),
                new SqlParameter("@DataType",model.Datatype),
                new SqlParameter("@IsmaxAlarm",model.Ismaxalarm),
                new SqlParameter("@IsminAlarm",model.Isminalarm),
                new SqlParameter("@AlarmMax",model.Alarmmax),
                new SqlParameter("@AlarmMin",model.Alarmmin),
                new SqlParameter("@Isfile",model.Isfile),
                new SqlParameter("@AlarmMaxNode",model.AlarmMaxNode),
                new SqlParameter("@AlarmMinNode",model.AlarmMinNode),
                new SqlParameter("@Scale",model.Scale),
                new SqlParameter("@OffsetorLength",model.Offsetorlength),
                new SqlParameter("@Comments",model.Comments)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, sqlParameters));
        }

        /// <summary>
        /// 验证添加变量名是否重复,在项目下面
        /// </summary>
        /// <param name="CGid"></param>
        /// <param name="VariableName"></param>
        /// <returns></returns>
        public bool IsRefareForInsert(int Projectid, String VariableName)
        {
            string sql = "select count(*) from Variables" +
                " inner join  CommunicationsGroups" +
                " on CommunicationsGroups.cgid=Variables.Cgid" +
                " inner  join Equipments" +
                " on Equipments.Equipmentid =CommunicationsGroups.Equipmentid" +
                " inner join Projects" +
                " on Projects.Projectid=Equipments.Projectid" +
                " where  Projects.projectid=@projectid and VariableName=@VariableName";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@projectid",Projectid),
                new SqlParameter("@VariableName",VariableName)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, sqlParameters)) > 0;
        }

        /// <summary>
        /// 验证变量名是否和通信组名称重复
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public bool VarNameIsAllowt(string varName)
        {
            string sql = "select count(*) from CommunicationsGroups" +
                " where CGname=@variableName";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@variableName",varName)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, sqlParameters)) > 0;
        }

        /// <summary>
        /// 修改变量
        /// </summary>
        /// <param name="variableID"></param>
        /// <returns></returns>
        public bool UpdateVariable(VariablesModel model)
        {

            string sql = "Update Variables" +
                " set VariableName=@VariableName,StartAddRess=@StartAddRess,Datatype=@DataType,IsmaxAlarm=@IsmaxAlarm,IsminAlarm=@IsminAlarm," +
                " AlarmMax=@AlarmMax,AlarmMin=@AlarmMin,Isfile=@Isfile,AlarmMaxNode=@AlarmMaxNode,AlarmMinNode=@AlarmMinNode," +
                " Scale=@Scale,OffsetorLength=@OffsetorLength,Comments=@Comments" +
                " where VariableID=@VariableID";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@VariableID",model.Variableid),
                new SqlParameter("@VariableName",model.Variablename),
                new SqlParameter("@StartAddRess",model.Startaddress),
                new SqlParameter("@DataType",model.Datatype),
                new SqlParameter("@IsmaxAlarm",model.Ismaxalarm),
                new SqlParameter("@IsminAlarm",model.Isminalarm),
                new SqlParameter("@AlarmMax",model.Alarmmax),
                new SqlParameter("@AlarmMin",model.Alarmmin),
                new SqlParameter("@Isfile",model.Isfile),
                new SqlParameter("@AlarmMaxNode",model.AlarmMaxNode),
                new SqlParameter("@AlarmMinNode",model.AlarmMinNode),
                new SqlParameter("@Scale",model.Scale),
                new SqlParameter("@OffsetorLength",model.Offsetorlength),
                new SqlParameter("@Comments",model.Comments)
             };
            return SQLHelper.GetExecuteNonQuery(sql, sqlParameters) > 0;
        }

        /// <summary>
        /// 验证修改的变量名是否正确
        /// </summary>
        /// <param name="VariableName"></param>
        /// <param name="VariableID"></param>
        /// <param name="CGid"></param>
        /// <returns></returns>
        public bool IsRefareforUpdate(string VariableName, int VariableID, int CGid)
        {
            string sql = "select count(*) from Variables" +
                " where CGid=@CGid and variableID<>@variableID and variableName=@variableName";
            SqlParameter[] sqlparameter = new SqlParameter[]
            {
                new SqlParameter("@CGid",CGid),
                new SqlParameter("@variableName",VariableName),
                new SqlParameter("@variableID",VariableID)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, sqlparameter)) > 0;
        }

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="VariableID"></param>
        /// <returns></returns>
        public bool DeleteVariable(int VariableID)
        {
            string sql = "Delete from Variables where variableID=@variableID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("variableID",VariableID)
            };
            return SQLHelper.GetExecuteNonQuery(sql, sqlParameters) > 0;
        }

        /// <summary>
        /// 查询对应通信组的变量
        /// </summary>
        /// <param name="cgId"></param>
        /// <returns></returns>
        public List<VariablesModel> QueryVariable(int cgId)
        {
            DataTable dt = new DataTable();
            string sql = "select VariableName,VariableId,CommunicationsGroups.Cgid,Variables.StartAddRess," +
                " DataType,Ismaxalarm,Isminalarm,Alarmmax,Alarmmin,Isfile,AlarmMaxNode,AlarmMinNode," +
                " Scale,Offsetorlength,Variables.comments " +
                " from Variables" +
                " inner join CommunicationsGroups" +
                " on Variables.Cgid=CommunicationsGroups.Cgid" +
                " where Variables.Cgid=@Cgid";
            SqlParameter[] sqlparameter = new SqlParameter[]
            {
                new SqlParameter("@Cgid",cgId)
            };
            List<VariablesModel> list = new List<VariablesModel>();
            dt = SQLHelper.GetDataTable(sql, sqlparameter);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new VariablesModel()
                {
                    SN = list.Count + 1,
                    Variableid = Convert.ToInt32(item["variableid"].ToString()),
                    Variablename = item["variableName"].ToString(),
                    Cgid = Convert.ToInt32(item["cgid"].ToString()),
                    Startaddress = item["Startaddress"].ToString(),
                    Datatype = item["DataType"].ToString(),
                    Ismaxalarm = Convert.ToBoolean(item["Ismaxalarm"]),
                    Isminalarm = Convert.ToBoolean(item["Isminalarm"]),
                    Isfile = Convert.ToBoolean(item["isfile"]),
                    Alarmmax = item["alarmmax"].ToString(),
                    Alarmmin = item["aLarmmin"].ToString(),
                    Scale = item["scale"].ToString(),
                    Offsetorlength = item["offsetorlength"].ToString(),
                    Comments = item["Comments"].ToString()
                });
            }
            return list;
        }

        /// <summary>
        /// 添加多个变量对象
        /// </summary>
        /// <param name="varList"></param>
        /// <returns></returns>
        public bool InsertVariables(List<VariablesModel> varList)
        {
            string sql = "insert into Variables(VariableName,Cgid,StartAddRess,Datatype,IsmaxAlarm,IsminAlarm,AlarmMax," +
                " AlarmMin,Isfile,AlarmMaxNode,AlarmMinNode,Scale,OffsetorLength,Comments)" +
                " values(@VariableName,@Cgid,@StartAddRess,@DataType,@IsmaxAlarm," +
                " @IsminAlarm,@AlarmMax,@AlarmMin,@Isfile,@AlarmMaxNode,@AlarmMinNode," +
                " @Scale,@OffsetorLength,@Comments);select @@identity";
            List<SqlParameter[]> sqlParameters = new List<SqlParameter[]>();
            for (int i = 0; i < varList.Count; i++)
            {
                sqlParameters.Add(new SqlParameter[]
                {
                new SqlParameter("@VariableName",varList[i].Variablename),
                new SqlParameter("@Cgid",varList[i].Cgid),
                new SqlParameter("@StartAddRess",varList[i].Startaddress),
                new SqlParameter("@DataType",varList[i].Datatype),
                new SqlParameter("@IsmaxAlarm",varList[i].Ismaxalarm),
                new SqlParameter("@IsminAlarm",varList[i].Isminalarm),
                new SqlParameter("@AlarmMax",varList[i].Alarmmax),
                new SqlParameter("@AlarmMin",varList[i].Alarmmin),
                new SqlParameter("@Isfile",varList[i].Isfile),
                new SqlParameter("@AlarmMaxNode",varList[i].AlarmMaxNode),
                new SqlParameter("@AlarmMinNode",varList[i].AlarmMinNode),
                new SqlParameter("@Scale",varList[i].Scale),
                new SqlParameter("@OffsetorLength",varList[i].Offsetorlength),
                new SqlParameter("@Comments",varList[i].Comments)
                });
            }
            return SQLHelper.GetTransaction(sql, sqlParameters);
        }
    }
}
