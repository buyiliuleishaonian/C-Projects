using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ConfigLib
{
    public class JsonHelper
    {
        /// <summary>
        /// ʹ��Newtonsoft.json.dll�������л���Json�ַ���
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string EntityToJson<T>(T t)
        {
            try
            {
                return JsonConvert.SerializeObject(t, Newtonsoft.Json.Formatting.Indented);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// ʹ��Newtonsoft.json.dll ��Json�ַ��������л��ɶ���
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToEntity<T>(string json)
        {
            try
            {
                return (T)JsonConvert.DeserializeObject(json, typeof(T));
            }
            catch (Exception)
            {
                return default(T);
            }
        }

    }
}
