using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class P
    {
        int i;
        public P()
        {
            Console.WriteLine("I am in default of Parent");
        }
        public P(int i)
        {
            this.i = i;
            Console.WriteLine("I am in parent parameterized customer");
        }
    }
    class C:P
    {
        int k;
        public C()
        {
            Console.WriteLine("i am in default of Child");
        }
        public C(int k,int i):base(i)
        {
            this.k = k;
            
            
            Console.WriteLine();
        }

    }
    class TestP
    {
        static void Main(string[] args)
        {
            C c = new C();
            C c2 = new C(10, 20);
            
            
        }
        
    }
}
