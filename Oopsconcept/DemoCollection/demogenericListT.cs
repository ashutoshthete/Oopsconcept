using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.DemoCollection
{
    class demogenericListT
    {
        static void Main(string[] args)
        {
            List<int> al = new List<int>();
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add(2);
            al.RemoveAt(4);
            al.Insert(1, 5);
            Console.WriteLine(al.Contains(3));
            foreach(var data in al)
            {
                Console.WriteLine(data);
            }
            
        }
    }
    class sortbypercent : IComparer<Student>
    {
        public int Compare(Student x,Student y)
        {
            Console.WriteLine("Comparable");
            return x.Percent - y.Percent;
        }
    }
    class sortbyid : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            Console.WriteLine("sort by id");
            return x.Sid - y.Sid;
        }
    }
    class Student:IComparable<Student>
    {
        int sid;
        string name;
        int percent;

        public Student(int sid, string name, int percent)
        {
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }

        public int CompareTo(Student other)
        {
            /* if (this.sid < other.sid)
                 return +1;
             else if (this.sid > other.sid)
                 return -1;
             else
                 return 0;*/
           /* return this.sid - other.sid;*/
            return other.sid - this.sid;
           /* return this.name.CompareTo(other.name);*/
        }

        public override string ToString()
        {
            return $"ID={sid}  Name={name}  percentage={percent} ";
        }
    }
    class StudTest
    {
        static void Main(string[] args)
        {
            
            List<Student> st = new List<Student>();
            st.Add(new Student(102, "ashutosh", 85));
            st.Add(new Student(111, "piya", 78));
            st.Add(new Student(103, "diya", 68));
            st.Add(new Student(101, "nisha", 98));
            st.Add(new Student(105, "Bob", 76));
            /* Console.WriteLine("ashutosh".CompareTo("Bob"));*/

            /*st.Sort();*/

            /*st.Sort(new sortbypercent());*/

            st.Sort(new sortbyid());
            foreach(var sobj in st)
            {
                Console.WriteLine(sobj);
            }
        }
    }
}
