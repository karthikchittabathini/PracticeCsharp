using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    public class Getterandsetter
    {
        string student_name;
        string student_dept;
        int student_idNo;

        public Getterandsetter(string studentName, string studentDept, int studentIdNo)
        {
            this.student_name = studentName;
            this.student_dept = studentDept;
            this.student_idNo = studentIdNo;
        }

        public string StudentName
        {
            get { return student_name; }
        }

        public int Student_rollno
        {
            get { return student_idNo; }
            set { student_idNo = value;}
        }
        public void display()
        {
            Console.WriteLine("Hiii, i am " + student_name);
            Console.WriteLine(student_idNo);
        }
    }
}
