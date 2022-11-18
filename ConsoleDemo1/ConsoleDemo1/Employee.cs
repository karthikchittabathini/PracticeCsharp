using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(Id + " - " + Name);
        }
    }
}
