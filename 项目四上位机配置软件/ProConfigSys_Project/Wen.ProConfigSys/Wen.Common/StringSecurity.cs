using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Wen.Common
{
    /// <summary>
    /// 字符串加密类
    /// </summary>
    public class StringSecurity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        private StringSecurity() { }


        #region SHA1加密
        /// <summary>
        /// 使用SHA1加密字符串
        /// </summary>
        /// <param name="inputString">待加密的字符串</param>
        /// <returns>加密后的字符串（40个字符）</returns>
        public static string StringToSHA1Hash(string inputString)
        {
            SHA1CryptoServiceProvider sha1= new SHA1CryptoServiceProvider();
            byte[] encrypteBytes = sha1.ComputeHash(Encoding.ASCII.GetBytes(inputString));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encrypteBytes.Length; i++)
            {
                sb.AppendFormat("{0:x2}", encrypteBytes[i]);
            }
            return sb.ToString();
        }

        #endregion

        #region  DES加密/解密

        private static byte[] key = ASCIIEncoding.ASCII.GetBytes("uiertysd");
        private static byte[] iv = ASCIIEncoding.ASCII.GetBytes("99008855");

        public static string DESEncrypt(string inputString)
        {
            MemoryStream ms = null;
            CryptoStream cs = null;
            StreamWriter sw = null;
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                ms=new MemoryStream();
                cs = new CryptoStream(ms, des.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                sw=new StreamWriter(cs);
                sw.Write(inputString);
                sw.Flush();
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.GetBuffer(),0,(int)ms.Length);
            }
            finally 
            {
                if (sw != null) sw.Close();
                if (cs != null) cs.Close();
                if (ms != null) ms.Close();
            }
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="inputString">DES加密之后的字符串</param>
        /// <returns>返回字符串初始值</returns>
        public static string DESDecrypt(string inputString)
        {
            MemoryStream ms = null;
            CryptoStream cs = null;
            StreamReader sr = null;

            DESCryptoServiceProvider des=new DESCryptoServiceProvider();
            try
            {
                ms = new MemoryStream(Convert.FromBase64String(inputString));
                cs = new CryptoStream(ms,des.CreateDecryptor(key,iv),CryptoStreamMode.Read);
                sr=new StreamReader(cs);
                return sr.ReadToEnd();
            }
            finally
            {
                if(sr!=null)sr.Close();
                if(cs!=null) cs.Close();
                if(ms!=null)ms.Close();
            }
        }
        #endregion

    }
}
