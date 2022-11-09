using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Oopsconcept.DemoCollection
{
    class DemogenericStack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("sjj");
            st.Push("om");
            st.Push("C");

            Console.WriteLine("Popped element : "+st.Pop());
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }
        }
    }
    class demoqueue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(90);
            q.Enqueue(89);
            Console.WriteLine(q.Dequeue());
        }

        
    }
    class demoHashset 
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("A");
            hs.Add("B");
            hs.Add("C");
            hs.Add("C");
            foreach (var i in hs)
            {
                Console.WriteLine(i);
            }

            SortedSet<Student> hsst = new SortedSet<Student>();
            hsst.Add(new Student(3, "ashutosh", 90));
            hsst.Add(new Student(2, "pramod", 88));
            hsst.Add(new Student(1, "laxman", 55));

            
            foreach(var data in hsst)
            {
                Console.WriteLine(data);
            }

        }

        
    }
}
