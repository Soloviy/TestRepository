using System;
using System.IO;

namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "store.txt";
            StreamReader reader = new StreamReader(path);
            string line = "";

            if (!reader.EndOfStream)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Файл пустий");
            }

            reader.Close();

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(DateTime.Now.ToString());
            writer.Close();
        }
    }
}
