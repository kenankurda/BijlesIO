using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOForTest
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "log1.txt";

            string line = "This is additional text" + DateTime.Now;
            List<Person> list = new List<Person>() 
            { 
              new Person { FirstName="Kenan", LastName="Kurda", Age=50},
              new Person { FirstName="Saif", LastName="Al Adilee", Age=25},
              new Person { FirstName="Jarno", LastName="Maes", Age=22},
              new Person { FirstName="Francis", LastName="Bulu", Age=18}
            };

            //WriteListToFile(list, path);

            WriteToFile(line,path);

        }

        public static void WriteListToFile(List<Person> people, string path) 
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                foreach (var item in people)
                {
                    sw.WriteLine($"First Name: {item.FirstName}, Last Name: {item.LastName}, Age: {item.Age}");
                }
            }
        }

        public static void WriteToFile(string line, string path)
        {
           
            using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine(line);
            }
         
        }
    }
}
