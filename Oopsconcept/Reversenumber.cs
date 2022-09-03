using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Reversenumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            long num = long.Parse(Console.ReadLine());
            long reverse = 0;
            while (num > 0)
            {
                long r = num % 10;
                reverse = (reverse * 10) + r;
                num = num / 10;
            }
            Console.WriteLine("The Reverse Order is : " + reverse);
        }
    }
}
