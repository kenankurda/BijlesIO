using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BijlesIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\test\Dummy.txt";
            //Console.Write("Input your text : ");
            //string line = Console.ReadLine();
            //WriteToFile(line, path);

            string line =  ReadFromFile(path);


            Console.WriteLine(line);
        }
       
        public static void WriteToFile(string line, string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(line);
            streamWriter.Flush();
            fileStream.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public static string ReadFromFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string line = streamReader.ReadToEnd();
            //Console.WriteLine(line);
            fileStream.Flush();
            fileStream.Close();
            
            streamReader.Close();
            return line;
            

        }
    }
}
