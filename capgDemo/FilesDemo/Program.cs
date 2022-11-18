using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\test5.txt";

            if (!File.Exists(path))
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Hii, this is karthik");
                    sw.WriteLine("I am from .Net batch");
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
            }
            Console.ReadLine();
        }
    }
}
