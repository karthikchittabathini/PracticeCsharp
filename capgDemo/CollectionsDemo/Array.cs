using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo 
{
    public class Array 
    {
        int[] array1 = new int[10] {10,21,32,45,5,76,77,8,19,10};



        public void displayArrayContents()
        {
            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }

        }




    }

    public class Employee : IComparable<Employee>
    {
        private int empId;
        private string empName;
        private int empAge;

        public Employee(int empId, string empName, int empAge)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
        }

        public string GetEmployeeName()
        {
            return empName;
        }

        public void SetEmployeeName(string empName)
        {
            this.empName = empName;
        }

        public int GetEmployeeID()
        {
            return empId;
        }

        public void SetEmployeeID(int empId)
        {
            this.empId = empId;
        }

        public int GetEmployeeAge()
        {
            return empAge;
        }
        public void SetEmployeeAge(int empAge)
        {
            this.empAge = empAge;
        }

        public int CompareTo(Employee obj)
        {
            return empAge.CompareTo(obj.empAge);

        }

    }
    /*
    class Employee_SortByID : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.
        }

   
    }

    
    */
}
