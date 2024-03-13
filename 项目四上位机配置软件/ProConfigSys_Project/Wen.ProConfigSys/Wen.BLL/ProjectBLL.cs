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
    /// 项目类的数据逻辑层
    /// </summary>
    public class ProjectBLL
    {
        public ProjectDAL proDAL=new ProjectDAL();

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public  int AddProjects(ProjectsModel project)
        {
            return  proDAL.AddtProject(project);    
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        public int DeleteProjects(int projectID) 
        {
            return proDAL.DeleteProject(projectID);
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int UpdateProject(ProjectsModel project)
        {
            return proDAL.UpdateProject(project);
        }

        /// <summary>
        /// 查询新增项目名有无重复
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public bool IsRepeatforInsert(string projectName)
        {
            return proDAL.IsRepeatForInsert(projectName);
        }

        /// <summary>
        /// 修改查询是否有重复
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public bool IsRepeatforUpdate(ProjectsModel project)
        {
           return proDAL.IsRepeatForUpdate(project);    
        }

        /// <summary>
        /// 查询所有项目
        /// </summary>
        /// <returns></returns>
        public List<ProjectsModel> SelectProject()
        {
            return proDAL.SelectProject();
        }
    }
}
