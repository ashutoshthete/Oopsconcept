using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class23
    {
        static int palindrome(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            palindrome(num);
        }
    }
}
