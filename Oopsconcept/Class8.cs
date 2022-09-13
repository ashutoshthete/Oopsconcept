using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class8
    {
        public static void Sum(out int g)
        {
            g = 80;
            g = g + g;
        }
        static void Main(string[] args)
        {
            int g;
            Sum(out g);
            Console.WriteLine("the sum is :"+g);
        }
    }
}
