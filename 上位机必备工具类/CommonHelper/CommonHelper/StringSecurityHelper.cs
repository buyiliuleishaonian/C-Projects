using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace CommonHelper
{
    /// <summary>
    /// �ַ������ܽ�����
    /// </summary>
    public sealed class StringSecurityHelper
    {
        private StringSecurityHelper() { }

        #region DES ����/����

        private static byte[] key = ASCIIEncoding.ASCII.GetBytes("uiertysd");
        private static byte[] iv = ASCIIEncoding.ASCII.GetBytes("99008855");

        /// <summary>
        /// DES���ܡ�
        /// </summary>
        /// <param name="inputString">�����ַ�����</param>
        /// <returns>���ܺ���ַ�����</returns>
        public static string DESEncrypt(string inputString)
        {
            MemoryStream ms = null;
            CryptoStream cs = null;
            StreamWriter sw = null;

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                ms = new MemoryStream();
                cs = new CryptoStream(ms, des.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                sw = new StreamWriter(cs);
                sw.Write(inputString);
                sw.Flush();
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (cs != null) cs.Close();
                if (ms != null) ms.Close();
            }
        }

        /// <summary>
        /// DES���ܡ�
        /// </summary>
        /// <param name="inputString">�����ַ�����</param>
        /// <returns>���ܺ���ַ�����</returns>
        public static string DESDecrypt(string inputString)
        {
            MemoryStream ms = null;
            CryptoStream cs = null;
            StreamReader sr = null;

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                ms = new MemoryStream(Convert.FromBase64String(inputString));
                cs = new CryptoStream(ms, des.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            finally
            {
                if (sr != null) sr.Close();
                if (cs != null) cs.Close();
                if (ms != null) ms.Close();
            }
        }

        #endregion

        #region SHA1����
        /// <summary>
        /// ʹ��SHA1�����ַ���
        /// </summary>
        /// <param name="inputString">�����ܵ��ַ���</param>
        /// <returns>���ܺ���ַ�����40���ַ���</returns>
        public static string StringToSHA1Hash(string inputString)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] encrypteBytes = sha1.ComputeHash(Encoding.ASCII.GetBytes(inputString));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encrypteBytes.Length; i++)
            {
                sb.AppendFormat("{0:x2}", encrypteBytes[i]);
            }
            return sb.ToString();
        }

        #endregion

        #region MD5����
        /// <summary>
        /// MD5����
        /// </summary>
        /// <param name="password">��Ҫ���ܵ�����</param>
        /// <returns>���ؼ���֮���ʮ�����Ƶ��ַ���</returns>

        public static string MD5Encrypt(string password)
        {
            //������Ҫ����MD5����
            //MD5�Ǹ�������
            //ͨ��MD5���е�create�����ӣ�����ֵ��MD5��������ģ��һ������
            MD5 md5 = MD5.Create();
            //��ʼ�����ֽ�����
            //��Ҫ���ַ���ת���ֽ�����
            byte[] buffer = Encoding.Default.GetBytes(password);
            //��ʼ����,�õ�����һ���ֽ�����
            buffer = md5.ComputeHash(buffer);
            //���ֽ�����ת���ַ��������ַ�ʽ
            //1�����ǽ��ֽ�����ͨ�����뷽ʽת�ɶ�Ӧ���ִ�
            //2�����ǽ��ֽ�����ֱ��tostring�����������õ�ֻ�������ֽ��������ڵ������ռ�
            //3�����ֽ����������ÿһ��Ԫ�ض�ת���ַ�����
            string newstr = null;
            for (int i = 0; i < buffer.Length; i++)
            {
                newstr += buffer[i].ToString("x");//ʮ����ת��16����
            }
            return newstr;
        }
        #endregion

    }
}
