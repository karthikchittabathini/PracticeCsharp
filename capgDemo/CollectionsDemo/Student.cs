using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public int CompareTo(Student obj)
        {
            /*
            if (this.Id < obj.Id) return -1;
            else if (this.Id > obj.Id) return 1;
            else return 0;
            */
            return this.Id.CompareTo(obj.Id);
        }

    }

    public class comparer1 : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }

    public class comparer2 : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return a.Id.CompareTo(b.Id);
        }
    }

}
