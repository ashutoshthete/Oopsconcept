using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            
            Console.WriteLine("Enter The Number till you want to print : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write(num1+" "+num2+" ");
            for(int i = 2; i < num; ++i)
            {
                num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
    class fibseries
    {
        static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nth term");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(n));
        }
    }
}
