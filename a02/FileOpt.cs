using System;


namespace a02
{
    public class FileTools
    {
        public static void ReadTextFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void WriteTextFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    writer.WriteLine("Hello, World!"+i);
                }

            }
        }
    }
}
