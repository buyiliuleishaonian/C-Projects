using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace Wen.DAL
{
    /// <summary>
    /// 通用sql数据访问类
    /// </summary>
    public class SQLHelper
    {
        /// <summary>
        /// 调用UI中的app中的写好的数据库连接，服务器名，数据库名，sql登入的用户名和密码,通过解密得到
        /// </summary>

        private static string sqlStr = ConfigurationManager.ConnectionStrings["SQLstr"].ToString();
        // private static string sqlStr = Common.StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["SQLstr"].ToString());

        /// <summary>
        /// 通用增删改
        /// </summary>
        /// <param name="sqlstr">增删改的sql语句</param>
        /// <param name="paraments">对应参数化</param>
        /// <returns>返回受影响的行数</returns>
        /// <exception cref="Exception">返回执行异常的原因</exception>
        public static int GetExecuteNonQuery(string sqlstr, SqlParameter[] parametes)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sqlStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    if (parametes != null)
                    {
                        cmd.Parameters.AddRange(parametes);
                    }
                    int num = cmd.ExecuteNonQuery();
                    return num;
                }
            }
            catch (Exception ex)
            {
                //可以在这里写入日志
                string msg = $"{DateTime.Now}:执行public static int GetExecuteNonQuery(string sqlstr, SqlParameter[] parametes)出现异常{ex.Message}";
                throw new Exception(msg);
            }
        }



        /// <summary>
        /// 通用返回所查询单一结果
        /// </summary>
        /// <param name="sqlstr">增删改的sql语句</param>
        /// <param name="paraments">对应参数化</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object GetExecuteScalar(string sqlstr, SqlParameter[] parametes)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sqlStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    if (parametes != null)
                    {
                        cmd.Parameters.AddRange(parametes);
                    }
                    object value = cmd.ExecuteScalar();
                    return value;
                }
            }
            catch (Exception ex)
            {
                string msg = $"{DateTime.Now}:public static object GetExecuteScalar(string sqlstr, SqlParameter[] parametes)出现异常{ex.Message}";
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// 通用虚拟表读取
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlDataReader GetExecuteRead(string sqlstr, SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(sqlStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddRange(parameters);
            SqlDataReader sqlread = cmd.ExecuteReader();
            return sqlread;
        }

        /// <summary>
        /// 通用读取数据库表
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(string sqlstr, SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(sqlStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 查询一个表
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable GetDataTable(string sqlstr, SqlParameter[] parameters)
        {
            DataTable dt =new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(sqlStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 放回表中的某一行
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataRow GetDataRow(string sqlstr, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            DataRow dtRow = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlstr, con);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dtRow = dt.Rows[0];
                    }
                    return dtRow;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 通用的增删改事务
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool GetTranSaction(List<string> sqlstr)
        {
            bool value = false;
            SqlConnection con = new SqlConnection(sqlStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                //开启事务
                cmd.Transaction = con.BeginTransaction();
                foreach (string s in sqlstr)
                {
                    cmd.CommandText = s;
                    cmd.ExecuteNonQuery();
                }
                //提交事务
                cmd.Transaction.Commit();
                value = true;
            }
            catch (Exception ex)
            {
                //回滚事务
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务，就是将报错之前所执行的所有sql语句之后执行结果全部撤销
                    cmd.Transaction = null;
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                con.Close();
            }
            return value;
        }

        /// <summary>
        /// 执行事务 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlparameter"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool GetTransaction(string sql, List<SqlParameter[]> sqlparameter)
        {
            bool value= false;
            SqlConnection con= new SqlConnection(sqlStr);
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                con.Open() ;
                cmd.Transaction = con.BeginTransaction();//开启事务
                for (int i = 0; i < sqlparameter.Count; i++) 
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(sqlparameter[i]);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit() ;//提交事务（并清除自动事务）
                value = true;
            }
            catch(Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                    cmd.Transaction = null;
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                con.Close();
            }
            return value;
        }
    }
}
