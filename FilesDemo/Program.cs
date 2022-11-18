using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            File.Copy(@"E:\CAPGEMINI\projects\CSharpFundamentals\file1.txt", @"E:\CAPGEMINI\projects\CSharpFundamentals\file2.txt", true);

            var path = @"E:\CAPGEMINI\projects\CSharpFundamentals\file2.txt";
            var infoRead = File.ReadAllLines(path);

            foreach (var line in infoRead)
                Console.WriteLine(line);

            if (File.Exists(path))
                Console.WriteLine("The file was present and it was found using file.exists method");

            File.Delete(path);

            if (File.Exists(path))
                Console.WriteLine("The file was present and it was found using file.exists method");
            else
                Console.WriteLine("The file was not present");
            */

            var path = @"E:\CAPGEMINI\projects\CSharpFundamentals\file2.txt";
            var fileinfo = new FileInfo(path);
            if(fileinfo.Exists)
                Console.WriteLine("The file was present");
            Console.WriteLine(fileinfo.FullName);
            fileinfo.IsReadOnly = true;
            if(fileinfo.IsReadOnly)
                Console.WriteLine("The file was only read only");

        }
    }
}
