using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    static class Class17
    {
        public static int add(int x,int y)
        {
            int c = x + y;
            return c;

        }
        static void Main(string[] args)
        {
             int x = 10;
             int y = 20;
            Class17.add(x, y);


            Console.WriteLine("in static");
        }


    }
    
}
