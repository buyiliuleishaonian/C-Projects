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
    /// 变量业务逻辑层
    /// </summary>
    public class VariableBLL
    {
        /// <summary>
        /// 变量数据访问属性
        /// </summary>
        public VariableDAL VariableDAL { get; set; } = new VariableDAL();

        /// <summary>
        /// 添加变量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int InsertVariable(VariablesModel model)
        {
            return VariableDAL.InsertVariable(model);
        }

        /// <summary>
        /// 判断添加变量的变量名是否重复
        /// </summary>
        /// <param name="CGid"></param>
        /// <param name="VariableName"></param>
        /// <returns></returns>
        public bool IsRefareforInsert(int Projectid, string VariableName)
        {
            return VariableDAL.IsRefareForInsert(Projectid, VariableName);
        }

        /// <summary>
        /// 验证变量名称是否和通信组名称重复
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public bool VarNameIsAllowt(string varName)
        {
            return VariableDAL.VarNameIsAllowt(varName);
        }

        /// <summary>
        /// 修改变量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateVariable(VariablesModel model)
        {
            return VariableDAL.UpdateVariable(model);
        }

        /// <summary>
        /// 判断修改的变量名是否重复
        /// </summary>
        /// <param name="CGid"></param>
        /// <param name="VariableID"></param>
        /// <param name="VariableName"></param>
        /// <returns></returns>
        public bool IsRefareforUpdate(int CGid, int VariableID, string VariableName)
        {
            return VariableDAL.IsRefareforUpdate(VariableName, VariableID, CGid);
        }

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="variableID"></param>
        /// <returns></returns>
        public bool DeleteVariable(int variableID)
        {
            return VariableDAL.DeleteVariable(variableID);
        }

        /// <summary>
        /// 查询通信组对应的变量
        /// </summary>
        /// <param name="cgId"></param>
        /// <returns></returns>
        public List<VariablesModel> QueryVariable(int cgId)
        {
            return VariableDAL.QueryVariable(cgId);
        }


        /// <summary>
        /// 添加大量变量数据
        /// </summary>
        /// <param name="varList"></param>
        /// <returns></returns>
        public bool InsertVariables(List<VariablesModel> varList)
        {
            return VariableDAL.InsertVariables(varList);
        }
    }
}
