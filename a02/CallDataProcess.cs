using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a02
{

    public class TelePhoneData
    { 
        public string PhoneNumber { get; set; }
        public int Seconds { get; set; }
        public DateTime DateTime { get; set; }
    }

    /// <summary>
    /// 统计数据对象
    /// </summary>
    public class StaticDataObject 
    {
        public long TotleSeconds { get; set; }
        public long TotleCount { get; set; }
    }

    public class CallDataProcess
    {
        private static int recordCount = 10000000;

        /// <summary>
        /// 生成数据
        /// </summary>
        /// <param name="filePath"></param>
        public static void GenerateData(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < recordCount; i++)
                {
                    //13913812310,2024-12-25 12:32:12,56
                    string phoneNum = GetRandomPhoneNum();
                    DateTime dateTime = GetRandomDateTime();
                    int seconds = GetRandomSeconds();

                    string line = string.Format("{0},{1},{2}", phoneNum, dateTime.ToString("yyyy-MM-dd HH:mm:ss"), seconds);
                    writer.WriteLine(line);
                }
            }
        }

        public void StaticData(string filePath)
        {
            //统计按号段的分组对象
            Dictionary<string,StaticDataObject> groups = new Dictionary<string,StaticDataObject>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //解析
                    TelePhoneData data = Parser(line);

                    if (data == null) //忽略无效的数据
                        continue;

                    //查询号段的对照
                    string groupKey = GetGroupKeyByPhoneNumber(data.PhoneNumber);

                    StaticDataObject staticDataObject = null;
                    if (groups.ContainsKey(groupKey))
                        staticDataObject = groups[groupKey];
                    else
                    {
                        staticDataObject = new StaticDataObject();
                        groups.Add(groupKey,staticDataObject);
                    }

                    //进行统计
                    staticDataObject.TotleCount++;
                    staticDataObject.TotleSeconds += data.Seconds;
                }
            }
        }

        private string GetGroupKeyByPhoneNumber(string phoneNumber)
        {
            //获取电话号码的前7位
            throw new NotImplementedException();
        }

        /// <summary>
        /// 将数据解析成 TelePhoneData 对象
        /// </summary>
        /// <param name="line"></param>
        /// <returns>解析成功返回 TelePhoneData，遇到无效数据返回 null</returns>
        private TelePhoneData Parser(string line)
        {
            throw new NotImplementedException();
        }

        private static int GetRandomSeconds()
        {
            throw new NotImplementedException();
        }

        private static DateTime GetRandomDateTime()
        {
            throw new NotImplementedException();
        }


        private static string GetRandomPhoneNum()
        {
            throw new NotImplementedException();
        }
    }
}
