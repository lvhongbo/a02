using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace a02
{
    public class TelephoneData
    {
        public string PhoneNumber { get; set; }
        public int Seconds { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class StaticDataObject
    {
        public long TotleSeconds { get; set; }
        public long TotleCount { get; set; }
    }

    public class TelephoneDataProcess
    {
        public static void GenerateData(string filePath)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    //13913812310,2024-12-25 12:32:12,56
                    string phoneNum = GetRandomPhoneNum();
                    DateTime dateTime = GetRandomDatetime();
                    int seconds = GetRandomSeconds();

                    string line = string.Format("{0},{1},{2}", phoneNum, dateTime.ToString("yyyy-MM-dd HH:mm:ss"), seconds);
                    writer.WriteLine(line);
                }
            }
        }

        public void StaticData(string filePath)
        {
            Dictionary<string, StaticDataObject> groups = new Dictionary<string, StaticDataObject>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    TelephoneData data = Parse(line);

                    if (data == null)
                        continue;

                    string groupKey = GetGrouKeyByPhoneNumber(data.PhoneNumber);
                    if (groups.ContainsKey(groupKey))
                    {
                        groups[groupKey].TotleCount++;
                        groups[groupKey].TotleSeconds += data.Seconds;
                    }
                    else
                    {
                        StaticDataObject staticDataObject = new StaticDataObject();
                        staticDataObject.TotleSeconds = data.Seconds;
                        staticDataObject.TotleCount = 1;
                        groups.Add(groupKey, staticDataObject);
                    }
                }
            }
        }

        private Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
        private string GetGrouKeyByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        private static TelephoneData Parse(string line)
        {
            throw new NotImplementedException();
        }

        private static int GetRandomSeconds()
        {
            throw new NotImplementedException();
        }

        private static DateTime GetRandomDatetime()
        {
            throw new NotImplementedException();
        }

        private static string GetRandomPhoneNum()
        {
            throw new NotImplementedException();
        }
    }
}
