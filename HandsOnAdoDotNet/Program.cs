using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAceessLayer;
using BusinessObject;
using BusinessLayer;

namespace HandsOnAdoDotNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UserBO u = new UserBO();
            BusinessLayerclass bal = new BusinessLayerclass();    
            while (true)
            {
                Console.WriteLine("1 : Insert data into blogs table");
                Console.WriteLine("2 : Insert data into blogger table");
                Console.WriteLine("3 : show data from blog table");
                Console.WriteLine("4 : show data from blog table");
                Console.WriteLine("5 : Exit");

                Console.WriteLine("Please enter a option");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UserBO u = new UserBO();
                        Console.WriteLine("Please enter a blog id");
                        u.BlogID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a blog name");
                        u.BloggerName = Console.ReadLine();
                        Console.WriteLine("Please enter a blog context");
                        u.BlogContent = Console.ReadLine();
                        Console.WriteLine("Please enter the blog date");
                        u.BlogDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please enter a blogger id");
                        u.BloggerID = Convert.ToInt32(Console.ReadLine());
                        bal.InsertToBlog(u);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
