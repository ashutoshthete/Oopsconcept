using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Oopsconcept.DemoCollection
{
    class DemoSortedListKeyvaluePair
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(234, "hfhj");
            s1.Add(45, "kjnjk");
            s1.Add(2, "kjkjj");
            foreach(var i in s1)
            {
                Console.WriteLine(i.Key+"----->"+i.Value);
            }
        }
    }
    class sortedlistbyid : IComparable<Student>
    {
        static void Main(string[] args)
        {
            SortedList<Student, long> sm = new SortedList<Student, long>();
            sm.Add(new Student(234, "hfhj",78),9789455398);
            sm.Add(new Student(45, "kjnjk",98),9789455398);
            sm.Add(new Student(2, "kjkjj",62),9789455398);
            foreach (var i in sm)
            {
                Console.WriteLine(i.Key + "----->" + i.Value);
            }
        }

        public int CompareTo([AllowNull] Student other)
        {
            throw new NotImplementedException();
        }
    }
    
}
