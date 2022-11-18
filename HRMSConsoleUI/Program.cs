using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSentitieslib; // for Entities Layer
using HRMSBusinessLayerLIb; // for Business Layer

namespace HRMSConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Delete by Id");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Display all employees");
                Console.WriteLine("5. Find by id");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter Choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Add employee
                        AddEmployee();
                        break;
                    case 2:
                        //Delete by id
                        DeleteEmployee();
                        break;
                    case 3:
                        //Update employee
                        UpdateEmployee();
                        break;
                    case 4:
                        //display all
                        DisplayAllEmps();
                        break;
                    case 5:
                        //find by id
                        FindEmpByid();
                        break;
                    case 6:
                        Console.WriteLine("You are Exited ..... ");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break ;
                }
            }
            while (choice != 6);

        }
        static void AddEmployee()
        {
            //Getting the data from end user
            Employee emp = new Employee();
            Console.WriteLine("Enter ecode :");
            emp.Ecode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ename :");
            emp.Ename = Console.ReadLine();
            Console.WriteLine("Enter salary :");
            emp.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter deptid :");
            emp.Deptid = int.Parse(Console.ReadLine());

            //Insert using Business Layer
            HRMSBusinessLayer bll = new HRMSBusinessLayer();
            bool status = bll.AddEmployee(emp);
            if (status)
            {
                Console.WriteLine("Record inserted Successfully");
            }
            else
            {
                Console.WriteLine("Could not insert the record");
            }

        }

        static void DeleteEmployee()
        {
            
            Console.WriteLine("Enter ecode :");
            int Ecode = int.Parse(Console.ReadLine());

            HRMSBusinessLayer bll = new HRMSBusinessLayer();

            bool status = bll.DeleteEmpById(Ecode);
            if (status)
            {
                Console.WriteLine("Employee was deleted succesfully");
            }
            else
            {
                Console.WriteLine("Deletion failed");
            }


        }

        static void UpdateEmployee()
        {
            //Getting the data from end user
            Employee emp = new Employee();
            Console.WriteLine("Enter ecode :");
            emp.Ecode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ename :");
            emp.Ename = Console.ReadLine();
            Console.WriteLine("Enter salary :");
            emp.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter deptid :");
            emp.Deptid = int.Parse(Console.ReadLine());


            //Update using the business layer
            HRMSBusinessLayer bll = new HRMSBusinessLayer();

            bool status = bll.UpdateEmp(emp);

            if (status)
            {
                Console.WriteLine("Employee Updated succesfully");
            }
            else
            {
                Console.WriteLine("Updation failed");
            }

        }

        static void DisplayAllEmps()
        {
            //Get all the record
            HRMSBusinessLayer bll = new HRMSBusinessLayer();
            List<Employee> lstemps = new List<Employee>();
            lstemps = bll.GetAllEmps();
            if(lstemps.Count == 0)
            {
                Console.WriteLine("No records to display");
            }
            else
            {
                //display the records
                foreach(var e in lstemps)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}",e.Ecode,e.Ename,e.Salary,e.Deptid);
                }
            }
        }

        static void FindEmpByid()
        {
            //Take the ecode from end user for searching
            Console.WriteLine("Enter ecode :");
            int Ecode = int.Parse(Console.ReadLine());

            //Get the record using the Bussiness Layer
            HRMSBusinessLayer bll = new HRMSBusinessLayer();
            Employee emp = bll.GetEmpByid(Ecode);
            //display the employee data
            if(emp != null)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Ecode, emp.Ename, emp.Salary, emp.Deptid);
            else
                Console.WriteLine("Record not found");
            
        }
    }
}
