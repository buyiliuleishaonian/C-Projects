using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.Common
{
    
    public class CsvHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">CSV文件路径</param>
        /// <param name="hasTitle">是否将CSV文件的第一行读取为DataTable</param>
        /// <returns></returns>
        public static DataTable CsvToDataTable(string path,bool hasTitle=true)
        {
            DataTable dt = new DataTable(); //要输出的数据表
            StreamReader read=new StreamReader(path,Encoding.Default);
            bool bFrist = true;

            //逐行读取
            string line=string.Empty;
            while ((line=read.ReadLine())!=null)
            {
                string[] elements = line.Split(',');
                //第一次读取数据时，要创建数据列
                if (bFrist)
                {
                    for (int i = 0; i < elements.Length; i++) 
                    {
                        dt.Columns.Add();
                    }
                    bFrist=false;
                }

                //有标题时，第一行当作标题处理
                if (hasTitle)
                {
                    for (int i = 0; i < dt.Columns.Count && i < elements.Length; i++)
                    {
                        dt.Columns[i].ColumnName = elements[i];
                    }
                    hasTitle = false;
                }
                else//读取一行数据
                {
                    if (elements.Length == dt.Columns.Count)
                    {
                        dt.Rows.Add(elements);
                    }
                    else
                    {
                        throw new Exception("CSV格式错误:表格各行列数不一致");
                    }
                }
            }
            read.Close();

            return dt;
        }
    }
}
