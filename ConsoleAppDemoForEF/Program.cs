using ConsoleAppDemoForEF.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleAppDemoForEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("This is for the Categories Table");
                Console.WriteLine("1 - show data from the Table");
                Console.WriteLine("2 - Add data to the Table");
                Console.WriteLine("3 - Update data to the Table");
                Console.WriteLine("4 - Find data from the Table");
                Console.WriteLine("5 - delete data from the Table");
                Console.WriteLine("6 - Exit");

                Console.WriteLine("Please Enter the option :");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowRecord();
                        break;
                    case 2:
                        AddData();
                        break;
                    case 3:
                        UpdateData();
                        break;
                    case 4:
                        FindData();
                        break;
                    case 5:
                        DeleteData();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;

                }
            }
            Console.ReadLine();

        }

        private static void DeleteData()
        {
            NorthwindContext context = new NorthwindContext();

            Console.WriteLine("Please enter the category id you want to delete");
            int id = Convert.ToInt32(Console.ReadLine());

            Categories c = context.Categories.Find(id);
            
            if (c != null)
            {
                context.Categories.Remove(c);
                context.SaveChanges();
                Console.WriteLine("Record was deleted");
            }
            else
            {
                Console.WriteLine("The required record was not found");
            }
            Console.WriteLine("-----------------------------------");
        }

        private static void FindData()
        {
            NorthwindContext context = new NorthwindContext();

            Console.WriteLine("Please enter the category id you want to find");
            int id = Convert.ToInt32(Console.ReadLine());

            Categories c = context.Categories.Find(id);

            if (c != null)
            {
                Console.WriteLine(c.CategoryId);
                Console.WriteLine(c.CategoryName);
                Console.WriteLine(c.Description);
            }
            else
            {
                Console.WriteLine("The required record is not found");
            }
            Console.WriteLine("-----------------------------------");
        }

        private static void UpdateData()
        {
            NorthwindContext context = new NorthwindContext();

            Categories c = context.Categories.Find(9);

            Categories newdata = new Categories();

            Console.WriteLine("please enter the Updated category name : ");
            string categName = Console.ReadLine();

            Console.WriteLine("please enter the Updated category description");
            string categDesc = Console.ReadLine();

            newdata.CategoryName = categName;
            newdata.Description = categDesc;


            if (c != null)
            {
                c.CategoryName = newdata.CategoryName;
                c.Description = newdata.Description;
                context.Categories.Update(c);
                context.SaveChanges();
                Console.WriteLine("Records was sucessfully Updated");
            }
            else
            {
                Console.WriteLine("The record was not found");
            }

            Console.WriteLine("-----------------------------------");
        }

        private static void AddData()
        {
            NorthwindContext context = new NorthwindContext();

            Categories c = new Categories();

            Console.WriteLine("please enter the category name : ");
            string categName = Console.ReadLine();

            Console.WriteLine("please enter the category description");
            string categDesc = Console.ReadLine();

            //Console.WriteLine("show");


            c.CategoryName = categName;
            c.Description = categDesc;
            context.Categories.Add(c);
            context.SaveChanges();

            Console.WriteLine("-----------------------------------");
        }

        private static void ShowRecord()
        {
            NorthwindContext context = new NorthwindContext();

            DbSet<Categories> catlist = context.Categories;

            foreach (var x in catlist)
            {
                Console.WriteLine(x.CategoryId);
                Console.WriteLine(x.CategoryName);
                Console.WriteLine(x.Description);

                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
