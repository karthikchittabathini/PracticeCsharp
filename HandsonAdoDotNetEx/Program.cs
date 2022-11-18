using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessObjects;
using BusinessLayerr;

namespace HandsonAdoDotNetEx
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
                Console.WriteLine("3 : show data from blogs table");
                Console.WriteLine("4 : show data from blogger table");
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
                        u.BlogName = Console.ReadLine();
                        Console.WriteLine("Please enter a blog context");
                        u.BlogContent = Console.ReadLine();
                        Console.WriteLine("Please enter the blog date");
                        u.BlogDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please enter a blogger id");
                        u.BloggerID = Convert.ToInt32(Console.ReadLine());
                        bal.InsertToBlog(u);
                        break;
                    case 2:
                        UserBO b = new UserBO();
                        Console.WriteLine("Please enter a blogger id");
                        b.BloggerID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a blogger name");
                        b.BloggerName = Console.ReadLine();
                        Console.WriteLine("Please enter a blogger subject");
                        b.BloggerSubject = Console.ReadLine();
                        bal.InsertToBlogger(b);
                        break;
                    case 3:
                        bool status = bal.ShowBlogData();
                        break;
                    case 4:
                        bool statuss = bal.ShowBloggerData();
                        break;
                    case 5:
                        Environment.Exit(0);
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

