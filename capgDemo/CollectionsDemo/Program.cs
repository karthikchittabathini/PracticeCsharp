using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Program 
    {

        static void Main(string[] args)
        {

            //arrays
            /*
            Array array = new Array();
            array.displayArrayContents();
            */



            //ArrayList
            /*
            Arraylist arlst = new Arraylist();
            arlst.addcontentstoarraylist();
            */


            //Dictionary
            /*
            DictinoaryDemo dic = new DictinoaryDemo();
            dic.DictionaryStuff();
            */

            //IEnumerable
            //Ienumurator iem = new Ienumurator();

            /*
            List<Employee> listOfemployees = new List<Employee>();
            listOfemployees.Add(new Employee(1, "Karthik", 14218));
            listOfemployees.Add(new Employee(2, "Kavya", 12456));

            Console.WriteLine("Before sorting the id's : ");
            foreach (var emp in listOfemployees)
            {
                Console.WriteLine(emp.GetEmployeeAge());
            }


            listOfemployees.Sort();

            Console.WriteLine("After sorting the id's : ");
            foreach (var emp in listOfemployees)
            {
                Console.WriteLine(emp.GetEmployeeAge());
            }
            */


            List<Student> students = new List<Student>()
            {
            new Student{Name = "karthik", Id = 14218 },
            new Student{Name = "kavya", Id = 12345},
            new Student{Name = "Girish kumar", Id = 14210}
            };

            Console.WriteLine("Before sorting the List was : ");
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + " " + s.Id);
            }

            students.Sort();

            Console.WriteLine("After sorting the List was : ");
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + " " + s.Id);
            }

            comparer1 cp1 = new comparer1();
            students.Sort(cp1);
            Console.WriteLine("Names after sort : ");
            foreach (var s in students)
            {
                Console.WriteLine(s.Name + " " + s.Id);
            }

            comparer2 cp2 = new comparer2();
            students.Sort(cp2);
            Console.WriteLine("Id's after sort : ");
            foreach (var s in students)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }

            Console.ReadLine();
        }

    }
}
