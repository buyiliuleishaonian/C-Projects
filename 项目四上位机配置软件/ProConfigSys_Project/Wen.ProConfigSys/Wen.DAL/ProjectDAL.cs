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
    /// 项目类的数据访问层
    /// </summary>
    public class ProjectDAL
    {
        
        /// <summary>
        /// 新增项目
        /// </summary>
        /// <param name="project">项目对象</param>
        /// <returns>返回项目的序号</returns>
        public int AddtProject(ProjectsModel  project)
        {
            string sql = "insert into Projects(Projectname)" +
                " values(@projectName);" +
                " select @@identity";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@projectName",project.Projectname)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql,parameter));
        }

        /// <summary>
        /// 判断项目名是否重复
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public bool IsRepeatForInsert(string projectName)
        {
            string sql = "select count(*) from projects " +
                " where projectname=@projectname";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@projectname",projectName)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, param) )> 0 ? true : false;
        }

        /// <summary>
        /// 删除项目名
        /// </summary>
        /// <param name="projectID">项目序号</param>
        /// <returns></returns>
        public int DeleteProject(int projectID)
        {
            int num = 0;
            string sql = "delete from projects" +
                " where projectID=@projectid";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@projectid",projectID)
            };
            num= SQLHelper.GetExecuteNonQuery(sql,parameter);
            return num;
        }

        /// <summary>
        /// 修改项目名
        /// </summary>
        /// <param name="project">项目对象</param>
        /// <returns></returns>
        public int UpdateProject(ProjectsModel project )
        {
            int num = 0;
            string sql = "update projects" +
                " set projectName=@projectName" +
                " where projectID=@projectId";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@projectId",project.Projectid),
                new SqlParameter("@projectName",project.Projectname)
            };
            num = SQLHelper.GetExecuteNonQuery(sql, parameter);
            return num;
        }


        /// <summary>
        /// 修改项目，判断项目名是否重复
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public bool IsRepeatForUpdate(ProjectsModel project)
        {
            string sql = "select count(*) from projects " +
                " where projectname=@projectname and projectid<>@projectid";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@projectname",project.Projectname),
                new SqlParameter("@projectid",project.Projectid)
            };
            return Convert.ToInt32(SQLHelper.GetExecuteScalar(sql, param)) > 0 ? true : false;
        }


        /// <summary>
        /// 查询所有项目
        /// </summary>
        /// <returns></returns>
        public List<ProjectsModel> SelectProject()
        {
            int sn = 0;
            List<ProjectsModel> list=new List<ProjectsModel>();
            DataTable dataTable = new DataTable();
            string sql = "select * from  projects" +
                " order by  projectid  ASC";
            dataTable= SQLHelper.GetDataTable(sql,null);
            foreach(DataRow item in dataTable.Rows) 
            {
                sn++;
                list.Add(new ProjectsModel() 
                {
                    SN=sn,
                    Projectid =Convert.ToInt32( item["projectid"]),
                    Projectname = item["ProjectName"].ToString()
                });
            }
            return list;
        }
    }
}
